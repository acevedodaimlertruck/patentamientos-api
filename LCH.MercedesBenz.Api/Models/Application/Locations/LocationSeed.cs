using LCH.MercedesBenz.Api.Models.Application.Locations;
using Microsoft.EntityFrameworkCore;

public static class LocationSeed
{
    public static void SeedLocations(this ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Location>().HasData(
                new Location { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
    );
    }
}