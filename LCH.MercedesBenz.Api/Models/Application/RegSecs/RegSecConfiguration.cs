using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.RegSecs
{
    public class RegSecConfiguration : IEntityTypeConfiguration<RegSec>
    {
        public void Configure(EntityTypeBuilder<RegSec> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
             .HasIndex(p => p.RegistryNumber);
        }
    }
}
