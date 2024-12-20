using LCH.MercedesBenz.Api.Models.Application.Gears;
using Microsoft.EntityFrameworkCore;

public static class GearSeed
{
    public static void SeedGear(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gear>().HasData(
         new Gear { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesGear = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}