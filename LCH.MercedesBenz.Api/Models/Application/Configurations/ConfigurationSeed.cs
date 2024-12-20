using LCH.MercedesBenz.Api.Models.Application.Configurations;
using Microsoft.EntityFrameworkCore;

public static class ConfigurationSeed
{
    public static void SeedConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Configuration>().HasData(
         new Configuration { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesConfiguration = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}