using LCH.MercedesBenz.Api.Models.Application.OFMM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.FechaCierres
{
    public class FechaCierreConfiguration : IEntityTypeConfiguration<FechaCierre>
    {
        public void Configure(EntityTypeBuilder<FechaCierre> builder)
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
