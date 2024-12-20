using LCH.MercedesBenz.Api.Models.Application.AltSegms;
using Microsoft.EntityFrameworkCore;

public static class AltSegmSeed
{
    public static void SeedAltSegm(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AltSegm>().HasData(
         new AltSegm { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesAltSegm = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}