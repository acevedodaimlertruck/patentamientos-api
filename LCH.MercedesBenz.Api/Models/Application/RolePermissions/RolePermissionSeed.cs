using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.RolePermissions
{
    public static class RolePermissionSeed
    {
        public static void SeedRolePermissions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolePermission>().HasData(
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000007") }

                // Another user permissions
                //new RolePermission { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"), PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
            );
        }
    }
}
