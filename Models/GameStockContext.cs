using Microsoft.EntityFrameworkCore;

namespace GameStock.Models
{
    public class GameStockContext : DbContext
    {
        public GameStockContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameReview> GameReviews { get; set; }
    }
}
