using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers;
using Microsoft.EntityFrameworkCore;

public static class EstimatedTurnoverSeed
{
    public static void SeedEstimatedTurnovers(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EstimatedTurnover>().HasData(
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesEstimatedTurnover = "1", DescriptionShort = "< $500.000", DescriptionLong = "< $500.000" },
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), MercedesEstimatedTurnover = "2", DescriptionShort = "$500.000~ $1.000.000", DescriptionLong = "$500.000 ~ $1.000.000" },
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), MercedesEstimatedTurnover = "3", DescriptionShort = "$1000000 ~ $5000000", DescriptionLong = "$1.000.000 ~ $5.000.000" },
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), MercedesEstimatedTurnover = "4", DescriptionShort = "$5000000 ~ $20000000", DescriptionLong = "$5.000.000 ~ $20.000.000" },
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), MercedesEstimatedTurnover = "5", DescriptionShort = "$20000000~$100000000", DescriptionLong = "$20.000.000 ~ $100.000.000" },
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), MercedesEstimatedTurnover = "6", DescriptionShort = "> $100.000.000", DescriptionLong = "> $100.000.000" },
         new EstimatedTurnover { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesEstimatedTurnover = "999", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );
    }
}