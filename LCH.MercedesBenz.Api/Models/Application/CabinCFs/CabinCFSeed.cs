using LCH.MercedesBenz.Api.Models.Application.CabinCFs;
using Microsoft.EntityFrameworkCore;

public static class CabinCFSeed
{
    public static void SeedCabinCF(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CabinCF>().HasData(
         new CabinCF { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesCabinCF = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}