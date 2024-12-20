using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations
{
    public static class InternalVersionSegmentationSeed
    {
        public static void SeedInternalVersionSegmentations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InternalVersionSegmentation>().HasData(
                new InternalVersionSegmentation { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Cat_InternalVersionId = Guid.Parse("00000000-0000-0000-0000-000000000033"), CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000033"), SegmentId = Guid.Parse("00000000-0000-0000-0000-000000000033"), Description = "NOASIGNADO", BodyStyleId = Guid.Parse("00000000-0000-0000-0000-000000000033"), BodyworkId = Guid.Parse("00000000-0000-0000-0000-000000000033"), PowerId = Guid.Parse("00000000-0000-0000-0000-000000000033"), SubsegmentId = Guid.Parse("00000000-0000-0000-0000-000000000033"), TractionId = Guid.Parse("00000000-0000-0000-0000-000000000033"), UsageId = Guid.Parse("00000000-0000-0000-0000-000000000033") }
                );
        }
    }
}
