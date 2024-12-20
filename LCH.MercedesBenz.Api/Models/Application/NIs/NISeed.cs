using LCH.MercedesBenz.Api.Models.Application.NIs;
using Microsoft.EntityFrameworkCore;

public static class NISeed
{
    public static void SeedNI(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NI>().HasData(
         new NI { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesNI = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}