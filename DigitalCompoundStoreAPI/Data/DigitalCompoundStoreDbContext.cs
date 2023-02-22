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
    public DbSet<FacilityType> FacilityTypes { get; set; } // TODO change enum to something simpler to migrate
    public DbSet<VideoGamePlatform> VideoGamePlatforms { get; set; } // TODO change enum to something simpler to migrate

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Facility>()
            .Property(p => p.FacilityType)
            .HasConversion<string>();
    }
}
