using System;
using System.ComponentModel.DataAnnotations;

namespace GameStock.Models
{
    public class LikedGame
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int ReviewId { get; set; }
        [Required(ErrorMessage = "is required.")]
        [MinLength(5, ErrorMessage = "must be at least 5 characters")]
        [Display(Name = "Game Review")]
        public string GameReview { get; set; }
        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Game Rating")]
        public int GameRating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public int UserId { get; set; }
        public User CreatedBy { get; set; }


        public int GameId { get; set; }
        public Game Games { get; set; }

    }
}