using LCH.MercedesBenz.Api.Models.Application.Powers;
using Microsoft.EntityFrameworkCore;

public static class PowerSeed
{
    public static void SeedPowers(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Power>().HasData(
         new Power { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesPower = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}