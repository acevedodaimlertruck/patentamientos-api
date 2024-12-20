using LCH.MercedesBenz.Api.Models.Application.OFMM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM
{
    public class OfmmConfiguration : IEntityTypeConfiguration<Ofmm>
    {
        public void Configure(EntityTypeBuilder<Ofmm> builder)
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
