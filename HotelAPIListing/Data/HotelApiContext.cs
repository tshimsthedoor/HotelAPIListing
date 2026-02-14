using Microsoft.EntityFrameworkCore;

public class HotelApiContext : DbContext
{
    public HotelApiContext(DbContextOptions options) : base(options)
    {
    }
}