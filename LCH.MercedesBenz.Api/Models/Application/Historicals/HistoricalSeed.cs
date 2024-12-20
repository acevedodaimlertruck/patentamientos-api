using LCH.MercedesBenz.Api.Models.Application.Historicals;
using Microsoft.EntityFrameworkCore;

public static class HistoricalSeed
{
    public static void SeedHistoricals(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Historical>().HasData(
        //new Historical { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
        //);
    }
}