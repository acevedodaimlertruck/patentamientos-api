using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.RuleTypes
{
    public static class RuleTypeSeed
    {
        public static void SeedRuleTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RuleType>().HasData(
                new RuleType { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "RulePatenta" },
                new RuleType { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "RuleMensual" },
                new RuleType { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "RuleWhosale" }
                );
        }
    }
}
