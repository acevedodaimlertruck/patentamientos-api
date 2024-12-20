using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.KeyVersions
{
    public static class KeyVersionSeed
    {
        public static void SeedKeyVersions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KeyVersion>().HasData(
                new KeyVersion { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
                );
        }
    }
}
