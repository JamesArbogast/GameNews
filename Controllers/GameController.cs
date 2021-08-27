using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameStock.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace GameStock.Controllers
{
    public class GameController : Controller
    {
        private GameStockContext db;
        public GameController(GameStockContext context)
        {
            db = context;
        }
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }
        //CREATE
        [HttpGet("/games/new")]
        public IActionResult New()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("Create");
        }
        //Create() talks to form asp-action make sure its the same
        [HttpPost("/games/create")]
        public IActionResult Create(Game newGame)
        {

            // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("Create");
            }

            newGame.UserId = (int)uid;
            db.Games.Add(newGame);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }
        //READ
        [HttpGet("/Dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            var client = new RestClient("https://rawg-video-games-database.p.rapidapi.com/games");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "rawg-video-games-database.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "0f4b745fe9mshbe29f523ee718eep15fe8ajsnbb2b87bacabe");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(client);

            List<Game> allGames = db.Games // hover over the param to see it's data type
                                           // .Include(game => game.LikedGames)
                .ToList();

            
            ViewBag.reviews = db.GameReviews
                .Include(u => u.CreatedBy);

            return View("Dashboard", allGames);
        }
        //READ
        [HttpGet("/games/{gameId}")]
        public IActionResult Details(int gameId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            
            Game game = db.Games
                .Include(game => game.CreatedBy)
                .ThenInclude(r => r.GameReviews)
                // .Include(game => game.LikedGames)
                // Include something from the last thing that was included.
                // Include the User from the likes (hover over like param to see data type)
                // .ThenInclude(like => like.CreatedBy)
                .FirstOrDefault(l => l.GameId == gameId);

            ViewBag.GameReviews = db.GameReviews
                .Include(gamerev => gamerev.CreatedBy);

            //finding the average score for the game
            double length = 0;
            double rating = 0;
            foreach(GameReview gameRev in ViewBag.GameReviews)
            {
                length += 1;
                rating += gameRev.GameRating;
                Console.WriteLine(rating);
            }

            double average = Math.Round((rating/length), 2);
            ViewBag.AvgScore = average;
            
            if (game == null)
            {
                return RedirectToAction("Details");
            }

            return View("Details", game);
        }

        //DELETE
        [HttpPost("/games/{gameId}/delete")]
        public IActionResult Delete(int gameId)
        {
            Game game = db.Games.FirstOrDefault(p => p.GameId == gameId);

            if (game == null)
            {
                return RedirectToAction("Dashboard");
            }

            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        //UPDATE
        [HttpGet("/games/{gameId}/edit")]
        public IActionResult Edit(int gameId)
        {
            Game game = db.Games.FirstOrDefault(p => p.GameId == gameId);

            // The edit button will be hidden if you are not the author,
            // but the user could still type the URL in manually, so
            // prevent them from editing if they are not the author.
            if (game == null || game.UserId != uid)
            {
                return RedirectToAction("Dashboard");
            }

            return View("Edit", game);
        }

        [HttpPost("/games/{gameId}/update")]
        public IActionResult Update(int gameId, Game editedGame)
        {
            if (ModelState.IsValid == false)
            {
                editedGame.GameId = gameId;
                // Send back to the page with the current form edited data to
                // display errors.
                return View("Edit", editedGame);
            }

            Game dbGame = db.Games.FirstOrDefault(p => p.GameId == gameId);

            if (dbGame == null)
            {
                return RedirectToAction("Dashboard");
            }

            dbGame.Name = editedGame.Name;
            dbGame.Genres = editedGame.Genres;
            dbGame.Platforms = editedGame.Platforms;
            // dbGame.Prices = editedGame.Prices;
            // dbGame.Vendors = editedGame.Vendors;
            dbGame.Genres = editedGame.Genres;
            dbGame.CurrentRating = editedGame.CurrentRating;
            dbGame.ImgUrl = editedGame.ImgUrl;
            dbGame.UpdatedAt = DateTime.Now;

            db.Games.Update(dbGame);
            db.SaveChanges();

            /* 
            When redirecting to action that has params, you need to pass in a
            dict with keys that match param names and the value of the keys are
            the values for the params.
            */
            return RedirectToAction("Details", new { gameId = gameId });
        }

        [HttpGet("/gamereview/{gameId}/new")]
        public IActionResult Review()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("ReviewGame");
        }

        [HttpPost("/game/{gameId}/review")]
        public IActionResult AddReview(int gameId, GameReview newGameReview)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            GameReview existingGameReview = db.GameReviews
                .FirstOrDefault(r => r.UserId == (int)uid && r.GameId == gameId);

            if (existingGameReview == null)
            {
                newGameReview.GameId = gameId;
                newGameReview.UserId = (int)uid;
                db.GameReviews.Add(newGameReview);
            }

            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpPost("/games/{gameId}/like")]
        public IActionResult Like(int gameId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            GameReview reviewedGame = db.GameReviews
                .FirstOrDefault(rsvp => rsvp.UserId == (int)uid && rsvp.GameId == gameId);

            if (reviewedGame == null)
            {
                GameReview gameRev = new GameReview()
                {
                    GameId = gameId,
                    UserId = (int)uid
                };

                db.GameReviews.Add(gameRev);
            }
            else
            {
                db.GameReviews.Remove(reviewedGame);
            }


            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}