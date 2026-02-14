using HotelAPIListing.Data;
using Microsoft.EntityFrameworkCore;

public class HotelApiContext : DbContext
{
    public HotelApiContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "United States", ShortName = "US" },
            new Country { Id = 2, Name = "Canada", ShortName = "CA" },
            new Country { Id = 3, Name = "United Kingdom", ShortName = "UK" },
            new Country { Id = 4, Name = "Congo D.R", ShortName = "RDC" },
            new Country { Id = 5, Name = "France", ShortName = "FR" },
            new Country { Id = 6, Name = "South Africa", ShortName = "SA" }
        );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel { Id = 1, Name = "Hotel California", Address = "42 Sunset Blvd", Rating = 4.5, CountryId = 1 },
            new Hotel { Id = 2, Name = "Maple Leaf Inn", Address = "123 Maple Street", Rating = 4.0, CountryId = 2 },
            new Hotel { Id = 3, Name = "The Royal London", Address = "10 Downing Street", Rating = 4.8, CountryId = 3 },
            new Hotel { Id = 4, Name = "Congo Safari Lodge", Address = "456 Jungle Road", Rating = 4.2, CountryId = 4 },
            new Hotel { Id = 5, Name = "Parisian Elegance", Address = "789 Champs-Élysées", Rating = 4.7, CountryId = 5 },
            new Hotel { Id = 6, Name = "Cape Town Retreat", Address = "321 Ocean Drive", Rating = 4.3, CountryId = 6 }
        );
    }
}