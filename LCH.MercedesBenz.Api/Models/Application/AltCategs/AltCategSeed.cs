using LCH.MercedesBenz.Api.Models.Application.AltCategs;
using Microsoft.EntityFrameworkCore;

public static class AltCategSeed
{
    public static void SeedAltCateg(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AltCateg>().HasData(
         new AltCateg { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesAltCateg = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}