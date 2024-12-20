using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM
{
    public static class OfmmSeed
    {
        public static void SeedOfmms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ofmm>().HasData(
              new Ofmm { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), ZOFMM = "NOASIGNADO", Descripcion1 = "NOASIGNADO", Descripcion2 = "NOASIGNADO", CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033"), FactoryId = Guid.Parse("00000000-0000-0000-0000-000000000033")/*, BrandId = Guid.Parse("00000000-0000-0000-0000-000000000033")*/ }
              );
        }
    }
}
