using LCH.MercedesBenz.Api.Models.Application.CuitClassifications;
using Microsoft.EntityFrameworkCore;

public static class CuitClassificationSeed
{
    public static void SeedCuitClassifications(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CuitClassification>().HasData(
         new CuitClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesCuitClassification = "EF", DescriptionShort = "Entidad Financiera", DescriptionLong = "Entidad Financiera" },
         new CuitClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesCuitClassification = "NO", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );
    }
}