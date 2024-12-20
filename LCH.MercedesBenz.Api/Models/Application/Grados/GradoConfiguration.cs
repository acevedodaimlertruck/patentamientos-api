using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.Grados
{
    public class GradoConfiguration : IEntityTypeConfiguration<Grado>
    {
        public void Configure(EntityTypeBuilder<Grado> builder)
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
