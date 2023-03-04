using Microsoft.EntityFrameworkCore;
using DigitalCompoundStoreAPI.Entities;
using System.Reflection.Emit;
using System;

namespace DigitalCompoundStoreAPI.Data;

public class DigitalCompoundStoreDbContext : DbContext
{
    public DigitalCompoundStoreDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<PriceUsed> PricesUsed { get; set; }
    public DbSet<Facility> Facilities { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<VideoGame> VideoGames { get; set; }
    //public DbSet<FacilityType> FacilityTypes { get; set; } // TODO change enum to something simpler to migrate                // added type conversion below instead
    //public DbSet<VideoGamePlatform> VideoGamePlatforms { get; set; } // TODO change enum to something simpler to migrate      // --||--

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .IsRequired();

        modelBuilder.Entity<Price>()
            .Property(p => p.PriceBuy)
            .IsRequired();

        modelBuilder.Entity<PriceUsed>()
            .Property(p => p.PriceBuy)
            .IsRequired();

        modelBuilder.Entity<Facility>()                     // type conversion for enum
            .Property(p => p.FacilityType)
            .HasConversion<string>();

        modelBuilder.Entity<VideoGame>()                    // type conversion for enum
            .Property(p => p.VideoGamePlatform)
            .HasConversion<string>();
    }
}
