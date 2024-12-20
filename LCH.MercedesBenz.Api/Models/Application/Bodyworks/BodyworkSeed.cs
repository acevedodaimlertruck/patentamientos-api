using LCH.MercedesBenz.Api.Models.Application.Bodyworks;
using Microsoft.EntityFrameworkCore;

public static class BodyworkSeed
{
    public static void SeedBodyworks(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bodywork>().HasData(
         new Bodywork { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesBodywork = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}