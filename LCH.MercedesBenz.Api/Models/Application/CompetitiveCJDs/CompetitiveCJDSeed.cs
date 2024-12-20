using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs;
using Microsoft.EntityFrameworkCore;

public static class CompetitiveCJDSeed
{
    public static void SeedCompetitiveCJD(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompetitiveCJD>().HasData(
         new CompetitiveCJD { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesCompetitiveCJD = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}