using Microsoft.EntityFrameworkCore;

namespace ProjName.Models
{
    public class GameNewsContext : DbContext
    {
        public GameNewsContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
