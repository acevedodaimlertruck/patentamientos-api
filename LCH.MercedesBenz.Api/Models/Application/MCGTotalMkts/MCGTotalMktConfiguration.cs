using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts
{
    public class MCGTotalMktConfiguration : IEntityTypeConfiguration<MCGTotalMkt>
    {
        public void Configure(EntityTypeBuilder<MCGTotalMkt> builder)
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
