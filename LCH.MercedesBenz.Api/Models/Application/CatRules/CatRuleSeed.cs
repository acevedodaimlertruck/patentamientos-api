using LCH.MercedesBenz.Api.Models.Application.CatRules;
using Microsoft.EntityFrameworkCore;

public static class CatRuleSeed
{
    public static void SeedCatRule(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatRule>().HasData(
         new CatRule { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesCatRule = "999", Description = "NOASIGNADO", SegCategory = "NOA"}
        );
    }
}