using LCH.MercedesBenz.Api.Models.Application.AperturesOne;
using Microsoft.EntityFrameworkCore;

public static class ApertureOneSeed
{
    public static void SeedAperturesOne(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApertureOne>().HasData(
         new ApertureOne { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesApertureOne = "001", SegCategory = "NOA", DescriptionShort = "Banco", DescriptionLong = "Banco" },
         new ApertureOne { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), MercedesApertureOne = "002", SegCategory = "NOA", DescriptionShort = "Leasing", DescriptionLong = "Leasing" },
         new ApertureOne { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesApertureOne = "999", SegCategory = "NOA", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );
    }
}