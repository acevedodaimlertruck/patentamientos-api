using LCH.MercedesBenz.Api.Models.Application.AMGCompSets;
using Microsoft.EntityFrameworkCore;

public static class AMGCompSetSeed
{
    public static void SeedAMGCompSet(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AMGCompSet>().HasData(
         new AMGCompSet { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesAMGCompSet = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}