using LCH.MercedesBenz.Api.Models.Application.Factories;
using Microsoft.EntityFrameworkCore;

public static class FactorySeed
{
    public static void SeedFactories(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Factory>().HasData(
         new Factory { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
        );
    }
}