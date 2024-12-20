using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Segments
{
    public static class SegmentSeed
    {
        public static void SeedSegments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Segment>().HasData(
      new Segment { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), SegName = "NOA", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
     );
        }
    }
}
