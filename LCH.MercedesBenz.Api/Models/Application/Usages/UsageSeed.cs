using LCH.MercedesBenz.Api.Models.Application.Usages;
using Microsoft.EntityFrameworkCore;

public static class UsageSeed
{
    public static void SeedUsages(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usage>().HasData(
         new Usage { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesUsage = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}