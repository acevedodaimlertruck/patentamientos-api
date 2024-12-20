using LCH.MercedesBenz.Api.Models.Application.Tractions;
using Microsoft.EntityFrameworkCore;

public static class TractionSeed
{
    public static void SeedTractions(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Traction>().HasData(
         new Traction { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesTraction = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}