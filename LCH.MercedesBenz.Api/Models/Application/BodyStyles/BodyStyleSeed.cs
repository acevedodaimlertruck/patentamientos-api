using LCH.MercedesBenz.Api.Models.Application.BodyStyles;
using Microsoft.EntityFrameworkCore;

public static class BodyStyleSeed
{
    public static void SeedBodyStyles(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BodyStyle>().HasData(
         new BodyStyle { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesBodyStyle = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}