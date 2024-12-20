using LCH.MercedesBenz.Api.Models.Application.AltBodysts;
using Microsoft.EntityFrameworkCore;

public static class AltBodystSeed
{
    public static void SeedAltBodyst(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AltBodyst>().HasData(
         new AltBodyst { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesAltBodyst = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}