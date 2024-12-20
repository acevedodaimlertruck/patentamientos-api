using LCH.MercedesBenz.Api.Models.Application.Sources;
using Microsoft.EntityFrameworkCore;

public static class SourceSeed
{
    public static void SeedSource(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Source>().HasData(
         new Source { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesSource = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}