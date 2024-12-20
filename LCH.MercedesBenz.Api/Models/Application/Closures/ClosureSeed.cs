using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Closures
{
    public static class ClosureSeed
    {
        public static void SeedClosures(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FileType>().HasData(
            //    new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Diario"},
            //    new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Name = "Venta" },
            //    new FileType { Id = Guid.Parse("00000000-0000-0000-0000-000000000030"), Name = "Mensual"}
            //    );
        }
    }
}
