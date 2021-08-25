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

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User CreatedBy { get; set; }

        public List<LikedGame> LikedGames { get; set; }
    }
}