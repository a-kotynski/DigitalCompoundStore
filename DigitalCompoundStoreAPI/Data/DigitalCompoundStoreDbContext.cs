using Microsoft.EntityFrameworkCore;
using DigitalCompoundStoreAPI.Entities;

namespace DigitalCompoundStoreAPI.Data
{
    public class DigitalCompoundStoreDbContext : DbContext
    {
        public DigitalCompoundStoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
