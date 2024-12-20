using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications;
using Microsoft.EntityFrameworkCore;

public static class LogisticClassificationSeed
{
    public static void SeedLogisticClassifications(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LogisticClassification>().HasData(
         new LogisticClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesLogisticClassification = "001", DescriptionShort = "Transporte Pasajeros", DescriptionLong = "Transporte Pasajeros" },
         new LogisticClassification { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesLogisticClassification = "999", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );
    }
}