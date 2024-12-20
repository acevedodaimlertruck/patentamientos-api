using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts;
using Microsoft.EntityFrameworkCore;

public static class MCGTotalMktSeed
{
    public static void SeedMCGTotalMkt(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MCGTotalMkt>().HasData(
         new MCGTotalMkt { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesMCGTotalMkt = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}