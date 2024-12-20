using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives;
using Microsoft.EntityFrameworkCore;

public static class CJDCompetitiveSeed
{
    public static void SeedCJDCompetitive(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CJDCompetitive>().HasData(
         new CJDCompetitive { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesCJDCompetitive = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}