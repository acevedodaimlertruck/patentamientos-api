using LCH.MercedesBenz.Api.Models.Application.PBTTNs;
using Microsoft.EntityFrameworkCore;

public static class PBTTNSeed
{
    public static void SeedPBTTN(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PBTTN>().HasData(
         new PBTTN { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesPBTTN = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}