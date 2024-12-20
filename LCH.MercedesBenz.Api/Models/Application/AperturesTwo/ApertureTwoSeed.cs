using LCH.MercedesBenz.Api.Models.Application.AperturesTwo;
using Microsoft.EntityFrameworkCore;

public static class ApertureTwoSeed
{
    public static void SeedAperturesTwo(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApertureTwo>().HasData(
         new ApertureTwo { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesApertureTwo = "001", SegCategory = "NOA", DescriptionShort = "Automotriz", DescriptionLong = "Automotriz" },
         new ApertureTwo { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesApertureTwo = "999", SegCategory = "NOA", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
         );
    }
}