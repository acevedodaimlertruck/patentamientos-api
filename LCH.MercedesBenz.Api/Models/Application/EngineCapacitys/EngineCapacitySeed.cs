using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys;
using Microsoft.EntityFrameworkCore;

public static class EngineCapacitySeed
{
    public static void SeedEngineCapacity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EngineCapacity>().HasData(
         new EngineCapacity { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesEngineCapacity = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}