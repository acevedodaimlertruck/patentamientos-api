using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.StatePatentas
{
    public class StatePatentaConfiguration : IEntityTypeConfiguration<StatePatenta>
    {
        public void Configure(EntityTypeBuilder<StatePatenta> builder)
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
