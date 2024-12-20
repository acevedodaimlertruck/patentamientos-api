using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.Historicals
{
    public class HistoricalConfiguration : IEntityTypeConfiguration<Historical>
    {
        public void Configure(EntityTypeBuilder<Historical> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
            .HasIndex(p => p.Chassis);

            builder
            .HasIndex(p => p.Plate);

            builder
            .HasIndex(p => p.CUITOwner);

            builder
           .HasIndex(p => p.FMM_MTM);

            builder
            .HasIndex(p => p.Department);

            builder
            .HasIndex(p => p.Province);

            builder
           .HasIndex(p => p.Location);

            builder
            .HasIndex(p => p.RegNum);

            builder
            .HasIndex(p => p.CarModelPat);

            builder
           .HasIndex(p => p.BrandPat);
             
        }
    }
}
