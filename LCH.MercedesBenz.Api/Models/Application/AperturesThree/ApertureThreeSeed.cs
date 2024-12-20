using LCH.MercedesBenz.Api.Models.Application.ApertureThrees;
using Microsoft.EntityFrameworkCore;

public static class ApertureThreeSeed
{
    public static void SeedApertureThree(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApertureThree>().HasData(
         new ApertureThree { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesApertureThree = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}