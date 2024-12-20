using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings
{
    public class PatentingConfiguration : IEntityTypeConfiguration<Patenting>
    {
        public void Configure(EntityTypeBuilder<Patenting> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
                .Property(b => b.FechInsc)
                .HasColumnType("date");

            builder
                .Property(b => b.DepartmentId)
                .HasDefaultValue(Guid.Parse("25D46165-DA2E-4127-9239-AC868C1D535D"));

            builder
                .Property(b => b.LocationId)
                .HasDefaultValue(Guid.Parse("E8DB5422-48D1-49B2-A4D8-AD000C86D635"));

            builder
                .Property(b => b.ProvinceId)
                .HasDefaultValue(Guid.Parse("85926A2C-E316-46AD-ACAE-FD53124CCB21"));

            builder
                .Property(b => b.RegSecId)
                .HasDefaultValue(Guid.Parse("2BB7B784-0749-4EA5-9247-B8BEF1C5DCB2"));

            builder
              .HasIndex(p => new { p.Plate, p.Chasis });

        }
    }
}
