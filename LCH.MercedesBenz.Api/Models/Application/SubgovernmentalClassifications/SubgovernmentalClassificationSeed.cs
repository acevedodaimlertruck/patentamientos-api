using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications;
using Microsoft.EntityFrameworkCore;

public static class SubgovernmentalClassificationSeed
{
    public static void SeedSubgovernmentalClassifications(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SubgovernmentalClassification>().HasData(
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesSubgovernmentalClassification = "001", DescriptionShort = "Nacional", DescriptionLong = "Nacional" },
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), MercedesSubgovernmentalClassification = "002", DescriptionShort = "Provincial", DescriptionLong = "Provincial" },
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), MercedesSubgovernmentalClassification = "003", DescriptionShort = "Municipal", DescriptionLong = "Municipal" },
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), MercedesSubgovernmentalClassification = "004", DescriptionShort = "CABA", DescriptionLong = "CABA" },
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), MercedesSubgovernmentalClassification = "005", DescriptionShort = "Internacional", DescriptionLong = "Internacional" },
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), MercedesSubgovernmentalClassification = "006", DescriptionShort = "Interjurisdiccional", DescriptionLong = "Interjurisdiccional" },
         new SubgovernmentalClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesSubgovernmentalClassification = "999", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );
    }
}