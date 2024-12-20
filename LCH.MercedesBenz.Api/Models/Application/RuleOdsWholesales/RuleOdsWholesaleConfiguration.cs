using LCH.MercedesBenz.Api.Models.Application.RulePatentings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.RuleOdsWholesales
{
    public class RuleOdsWholesaleConfiguration : IEntityTypeConfiguration<RuleOdsWholesale>
    {
        public void Configure(EntityTypeBuilder<RuleOdsWholesale> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        }
    }
}
