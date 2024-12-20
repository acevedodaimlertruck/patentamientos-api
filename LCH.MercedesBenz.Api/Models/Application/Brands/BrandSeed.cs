using LCH.MercedesBenz.Api.Models.Application.Brands;
using Microsoft.EntityFrameworkCore;

public static class BrandSeed
{
    public static void SeedBrands(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>().HasData(
            new Brand { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO", TerminalId = Guid.Parse("00000000-0000-0000-0000-000000000033") }
        );
    }
}