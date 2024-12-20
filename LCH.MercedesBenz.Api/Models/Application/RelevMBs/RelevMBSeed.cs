using LCH.MercedesBenz.Api.Models.Application.RelevMBs;
using Microsoft.EntityFrameworkCore;

public static class RelevMBSeed
{
    public static void SeedRelevMB(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RelevMB>().HasData(
         new RelevMB { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesRelevMB = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}