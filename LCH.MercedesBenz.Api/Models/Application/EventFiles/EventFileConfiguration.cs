using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles
{
    public class EventFileConfiguration : IEntityTypeConfiguration<EventFile>
    {
        public void Configure(EntityTypeBuilder<EventFile> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
                .HasIndex(b => b.Id)
                .IsUnique();
        }
    }
}
