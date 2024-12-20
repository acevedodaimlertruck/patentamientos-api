using LCH.MercedesBenz.Api.Models.Application.PatentingVersions;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.WholesaleVersions
{
    public static class WholesaleVersionSeed
    {
        public static void SeedWholesaleVersions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WholesaleVersion>().HasData(
          new WholesaleVersion { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033"), Version = "NOASIGNADO", Description = "NOASIGNADO" }
         );
        }
    }
}
