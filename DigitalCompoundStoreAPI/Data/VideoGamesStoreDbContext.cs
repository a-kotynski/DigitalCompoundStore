using Microsoft.EntityFrameworkCore;
using DigitalCompoundStoreAPI.Entities;

namespace DigitalCompoundStoreAPI.Data
{
    public class VideoGamesStoreDbContext : DbContext
    {
        public VideoGamesStoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
