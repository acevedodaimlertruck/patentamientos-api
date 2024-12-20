using LCH.MercedesBenz.Api.Models.Application.Doors;
using Microsoft.EntityFrameworkCore;

public static class DoorSeed
{
    public static void SeedDoor(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Door>().HasData(
         new Door { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesDoor = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}