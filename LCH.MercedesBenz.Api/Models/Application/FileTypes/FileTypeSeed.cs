using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.FileTypes
{
    public static class FileTypeSeed
    {
        public static void SeedFileTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileType>().HasData(
                new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Diario"},
                new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Name = "Venta" },
                new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000030"), Name = "Mensual"},
                new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000040"), Name = "Ventas Especiales" },
                new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000050"), Name = "Histórico" }
                );
        }
    }
}
