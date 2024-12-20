using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions
{
    public static class InternalVersionSeed
    {
        public static void SeedInternalVersions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InternalVersion>().HasData(
                new InternalVersion { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), /*BrandId = Guid.Parse("00000000-0000-0000-0000-000000000033"), */CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033"), /*TerminalId = Guid.Parse("00000000-0000-0000-0000-000000000033"),*/ DescripcionVerInt = "NOASIGNADO" }
                );
        }
    }
}
