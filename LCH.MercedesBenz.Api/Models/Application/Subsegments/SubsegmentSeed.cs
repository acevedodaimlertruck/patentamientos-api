using LCH.MercedesBenz.Api.Models.Application.Subsegments;
using Microsoft.EntityFrameworkCore;

public static class SubsegmentSeed
{
    public static void SeedSubsegments(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Subsegment>().HasData(
         new Subsegment { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesSubsegment = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}