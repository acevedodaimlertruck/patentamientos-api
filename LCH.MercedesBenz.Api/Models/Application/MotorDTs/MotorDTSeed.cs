using LCH.MercedesBenz.Api.Models.Application.MotorDTs;
using Microsoft.EntityFrameworkCore;

public static class MotorDTSeed
{
    public static void SeedMotorDT(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MotorDT>().HasData(
         new MotorDT { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesMotorDT = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}