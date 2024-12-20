using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.StatePatentas
{
    public static class StatePatentaSeed
    {
        public static void SeedStatePatentas(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatePatenta>().HasData(
                new StatePatenta { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Borrador" },
                new StatePatenta { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Error" },
                new StatePatenta { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Exito" }
                );
        }
    }
}
