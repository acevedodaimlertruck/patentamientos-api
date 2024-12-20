using LCH.MercedesBenz.Api.Models.Application.AxleBases;
using Microsoft.EntityFrameworkCore;

public static class AxleBaseSeed
{
    public static void SeedAxleBase(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AxleBase>().HasData(
         new AxleBase { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesAxleBase = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}