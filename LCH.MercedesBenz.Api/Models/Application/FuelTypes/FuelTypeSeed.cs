using LCH.MercedesBenz.Api.Models.Application.FuelTypes;
using Microsoft.EntityFrameworkCore;

public static class FuelTypeSeed
{
    public static void SeedFuelType(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FuelType>().HasData(
         new FuelType { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesFuelType = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}