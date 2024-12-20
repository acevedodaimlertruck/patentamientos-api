using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions
{
    public class Cat_InternalVersionConfiguration : IEntityTypeConfiguration<Cat_InternalVersion>
    {
        public void Configure(EntityTypeBuilder<Cat_InternalVersion> builder)
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
