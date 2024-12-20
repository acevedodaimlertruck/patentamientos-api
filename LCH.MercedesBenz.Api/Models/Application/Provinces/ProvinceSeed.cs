using LCH.MercedesBenz.Api.Models.Application.Provinces;
using Microsoft.EntityFrameworkCore;

public static class ProvinceSeed
{
    public static void SeedProvinces(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
         new Province { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
        );
    }
}