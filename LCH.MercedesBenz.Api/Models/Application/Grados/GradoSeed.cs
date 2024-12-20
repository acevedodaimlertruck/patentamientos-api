using Microsoft.EntityFrameworkCore;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Grados
{
    public static class GradoSeed
    {
        public static void SeedGrados(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grado>().HasData(
            new Grado { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), CarModelId = Guid.Parse("00000000-0000-0000-0000-000000000033"), MarcaWs = "NOAS", ModeloWs = "NOASI", Grade = "NOASIGN", VersionWs = "NOAS" }
            );
        }
    }
}
