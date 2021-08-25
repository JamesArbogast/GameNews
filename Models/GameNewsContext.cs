using Microsoft.EntityFrameworkCore;

namespace GameStock.Models
{
    public class GameNewsContext : DbContext
    {
        public GameNewsContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
