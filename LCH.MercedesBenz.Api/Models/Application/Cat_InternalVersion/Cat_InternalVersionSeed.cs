using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions; 
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions
{
    public static class Cat_InternalVersionSeed
    {
        public static void SeedCat_InternalVersions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat_InternalVersion>().HasData(
          new Cat_InternalVersion { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033"), Version = "NOASIGNADO", Description = "NOASIGNADO", DateFrom = new DateTime(1000, 01, 01), DateTo = new DateTime(9999, 12, 31) }
         );
        }
    }
}
