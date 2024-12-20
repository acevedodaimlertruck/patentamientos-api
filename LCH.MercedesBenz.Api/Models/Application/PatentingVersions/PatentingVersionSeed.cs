using LCH.MercedesBenz.Api.Models.Application.PatentingVersions; 
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.PatentingVersions
{
    public static class PatentingVersionSeed
    {
        public static void SeedPatentingVersions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatentingVersion>().HasData(
          new PatentingVersion { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033"), Version = "NOASIGNADO", Description = "NOASIGNADO" }
         );
        }
    }
}
