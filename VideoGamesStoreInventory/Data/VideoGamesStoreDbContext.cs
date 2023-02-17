using Microsoft.EntityFrameworkCore;
using VideoGamesStoreInventory.Entities;

namespace VideoGamesStoreInventory.Data
{
    public class VideoGamesStoreDbContext : DbContext
    {
        public VideoGamesStoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
