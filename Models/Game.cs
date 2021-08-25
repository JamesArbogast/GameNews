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

		public List<string> Genres { get; set; }
		public List<string> Platforms { get; set; }
		public List<int> Prices { get; set; }
		public List<string> Vendors { get; set; }
		public int CurrentRating { get; set; } 
		public string Creator { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;

		public int UserId { get; set; }
		public User CreatedBy { get; set; }

		public List<LikedGames> LikedGames { get; set; }
	}
}
