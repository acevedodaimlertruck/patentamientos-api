using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s;
using Microsoft.EntityFrameworkCore;

public static class SegmentationAux1Seed
{
    public static void SeedSegmentationAux1(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SegmentationAux1>().HasData(
         new SegmentationAux1 { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesSegmentationAux1 = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}