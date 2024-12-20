using LCH.MercedesBenz.Api.Models.Application.CabinSDs;
using Microsoft.EntityFrameworkCore;

public static class CabinSDSeed
{
    public static void SeedCabinSD(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CabinSD>().HasData(
         new CabinSD { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesCabinSD = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}