using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.Provinces
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
             .HasIndex(p => p.MercedesProvinciaId);
        }
    }
}
