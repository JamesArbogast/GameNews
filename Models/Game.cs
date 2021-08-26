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
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        [Required(ErrorMessage = "Is required.")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Is required.")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "Genre")]
        public string Genres { get; set; }

        [Display(Name = "Platforms")]
        public string Platforms { get; set; }

        [Required(ErrorMessage = "Is required.")]

        // [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "Current Rating")]
        public int CurrentRating { get; set; }
        [Display(Name = "Creator")]
        public string Creator { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User CreatedBy { get; set; }

        public List<GameReview> GameReviews { get; set; }
    }
}
