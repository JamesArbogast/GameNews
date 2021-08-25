using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStock.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Is required.")]
<<<<<<< HEAD
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public List<string> Genres { get; set; }
        public List<string> Platforms { get; set; }
        public List<int> Prices { get; set; }
        public List<string> Vendors { get; set; }
        public int CurrentRating { get; set; } 
        public string Creator { get; set; }
=======
        [MinLength(1, ErrorMessage = "Must be at least 1 character.")]
        [Display(Name = "Game name")]
        public string GameName { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(5, ErrorMessage = "must be at least 5 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Rating")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Media Url")]
        public string Src { get; set; }
>>>>>>> ed79b0a373385a6ca1f8f3713a62cd17bbc8d386

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

<<<<<<< HEAD
=======
        public int UserId { get; set; }
        public User CreatedBy { get; set; }

        public List<LikedGame> LikedGames { get; set; }
>>>>>>> ed79b0a373385a6ca1f8f3713a62cd17bbc8d386
    }
}