using LCH.MercedesBenz.Api.Models.Application.WheelBases;
using Microsoft.EntityFrameworkCore;

public static class WheelBaseSeed
{
    public static void SeedWheelBase(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WheelBase>().HasData(
         new WheelBase { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesWheelBase = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}