using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using likedGames.Models;

namespace likedGames.Controllers
{
    public class GameController : Controller
    {
        private likedGameContext db;
        public GameController(likedGameContext context)
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
            if (!isLoggedIn) {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }
    //Create() talks to form asp-action make sure its the same
        [HttpPost("/games/create")]
        public IActionResult Create(Game newGame)
        {

            // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("New");
            }

            // if (newGame.Date <= DateTime.Now)
            // {
            //     ModelState.AddModelError("Date", "must be in the future.");
            //     return View("New");
            // }

            // If any above custom errors were added, ModelState would now be invalid.

            // HttpContext.Session.SetString("NameOne", newWedding.NameOne);
            newGame.UserId = (int)uid;
            db.Games.Add(newGame);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }
        //READ
        [HttpGet("/Dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn) {
                return RedirectToAction("Index", "Home");
            }
            
            List<Game> allGames = db.Games

                .Include(game => game.CreatedBy) // hover over the param to see it's data type
                
                .Include(game => game.likedGames)
                .ToList();
            return View("Dashboard", allGames);
        }
        //READ
        [HttpGet("/games/{gameId}")]
        public IActionResult Details(int gameId)
        {
            if (!isLoggedIn) {
                return RedirectToAction("Index", "Home");
            }


            Game game = db.Games
                .Include(game => game.CreatedBy)
                .Include(game => game.likedGames)
                // Include something from the last thing that was included.
                // Include the User from the likes (hover over like param to see data type)
                .ThenInclude(like => like.CreatedBy)
                .FirstOrDefault(l => l.GameId == gameId);


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

            dbGame.Title = editedGame.Title;
            dbGame.Description = editedGame.Description;
            dbGame.Rating = editedGame.Rating;
            dbGame.Src = editedGame.Src;
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



        [HttpPost("/games/{gameId}/like")]
        public IActionResult Like(int gameId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            LikedGame likedGame = db.LikedGames
                .FirstOrDefault(rsvp => rsvp.UserId == (int)uid && rsvp.GameId == gameId);

            if (likedGame == null)
            {
                LikedGame like = new LikedGame()
                {
                    GameId = gameId,
                    UserId = (int)uid
                };

                db.LikedGames.Add(like);
            }
            else
            {
                db.LikedGames.Remove(likedGame);
            }


            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}