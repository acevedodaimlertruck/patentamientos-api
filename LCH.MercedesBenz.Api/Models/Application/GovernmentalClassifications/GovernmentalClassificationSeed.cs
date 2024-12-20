using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications;
using Microsoft.EntityFrameworkCore;

public static class GovernmentalClassificationSeed
{
    public static void SeedGovernmentalClassifications(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GovernmentalClassification>().HasData(
         new GovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesGovernmentalClassification = "G1", DescriptionShort = "Entidad Gubernamenta", DescriptionLong = "Entidad Gubernamental" },
         new GovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), MercedesGovernmentalClassification = "G2", DescriptionShort = "Ent Cont por Estado", DescriptionLong = "Entidad Controlada por el Estado" },
         new GovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), MercedesGovernmentalClassification = "G3", DescriptionShort = "Per Fis rel Gobierno", DescriptionLong = "Persona Física relacionada al Gobierno" },
         new GovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), MercedesGovernmentalClassification = "NO", DescriptionShort = "NO", DescriptionLong = "NO" },
         new GovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesGovernmentalClassification = "XX", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );
    }
}