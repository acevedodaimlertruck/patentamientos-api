using LCH.MercedesBenz.Api.Models.Application.ApertureFours;
using Microsoft.EntityFrameworkCore;

public static class ApertureFourSeed
{
    public static void SeedApertureFour(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApertureFour>().HasData(
         new ApertureFour { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesApertureFour = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}