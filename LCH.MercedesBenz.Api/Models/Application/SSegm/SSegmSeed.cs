using LCH.MercedesBenz.Api.Models.Application.SSegms;
using Microsoft.EntityFrameworkCore;

public static class SSegmSeed
{
    public static void SeedSSegm(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SSegm>().HasData(
         new SSegm { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesSSegm = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}