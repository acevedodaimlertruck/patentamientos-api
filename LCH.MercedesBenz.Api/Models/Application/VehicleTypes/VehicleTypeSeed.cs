using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.VehicleTypes
{
    public static class VehicleTypeSeed
    {
        public static void SeedVehicleTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
            );
        }
    }
}
