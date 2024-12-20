using LCH.MercedesBenz.Api.Models.Application.PBTs;
using Microsoft.EntityFrameworkCore;

public static class PBTSeed
{
    public static void SeedPBT(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PBT>().HasData(
         new PBT { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesPBT = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}