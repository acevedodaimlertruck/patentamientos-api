using LCH.MercedesBenz.Api.Models.Application.CarModels;
using Microsoft.EntityFrameworkCore;

public static class CarModelSeed
{
    public static void SeedCarModels(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarModel>().HasData(
         new CarModel { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO", BrandId = Guid.Parse("00000000-0000-0000-0000-000000000033") }
        );
    }
}