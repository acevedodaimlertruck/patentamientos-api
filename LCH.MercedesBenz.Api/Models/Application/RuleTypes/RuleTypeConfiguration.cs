using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.RuleTypes
{
    public class RuleTypeConfiguration : IEntityTypeConfiguration<RuleType>
    {
        public void Configure(EntityTypeBuilder<RuleType> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
                .HasIndex(b => b.Name)
                .IsUnique();
        }
    }
}
