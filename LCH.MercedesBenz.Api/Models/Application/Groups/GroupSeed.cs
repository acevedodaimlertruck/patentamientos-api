using LCH.MercedesBenz.Api.Models.Application.Groups;
using Microsoft.EntityFrameworkCore;

public static class GroupSeed
{
    public static void SeedGroup(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>().HasData(
         new Group { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesGroup = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}