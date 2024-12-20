using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers
{
    public class EstimatedTurnoverConfiguration : IEntityTypeConfiguration<EstimatedTurnover>
    {
        public void Configure(EntityTypeBuilder<EstimatedTurnover> builder)
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
