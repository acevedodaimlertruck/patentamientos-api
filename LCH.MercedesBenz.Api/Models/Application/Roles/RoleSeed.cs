using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Roles
{
    public static class RoleSeed
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Super Admin", Description = "Super Admin" }
            );
        }
    }
}
