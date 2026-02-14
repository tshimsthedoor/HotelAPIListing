using HotelAPIListing.Data;
using Microsoft.EntityFrameworkCore;

public class HotelApiContext : DbContext
{
    public HotelApiContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }
}