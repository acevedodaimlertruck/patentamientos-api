using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.TMMVS
{
    public static class TMMVSeed
    {
        public static void SeedTMMVs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TMMV>().HasData(
                new TMMV { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), VersionPatentamiento = "NOASIGNADO", VersionWs = "NOASIGNADO", VersionInterna = "NOASIGNADO", DescripcionTerminal = "NOASIGNADO", DescripcionMarca = "NOASIGNADO", DescripcionModelo = "NOASIGNADO", DescripcionVerPat = "NOASIGNADO", DescripcionVerWs = "NOASIGNADO", DescripcionVerInt = "NOASIGNADO", /*BrandId = Guid.Parse("00000000-0000-0000-0000-000000000033"),*/ CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033")/*, TerminalId = Guid.Parse("00000000-0000-0000-0000-000000000033")*/ }
            );
        }
    }
}
