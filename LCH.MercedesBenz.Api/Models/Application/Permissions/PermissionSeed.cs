using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Permissions
{
    public static class PermissionSeed
    {
        public static void SeedPermissions(this ModelBuilder model)
        {
            model.Entity<Permission>().HasData(
                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Inicio", Description = "Inicio", Ordering = 100 },

                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Administración", Description = "Administración", Ordering = 200 },

                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Seguridad", Description = "Seguridad", Ordering = 400 },

                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Seguridad > Roles y Permisos", Description = "Seguridad > Roles y Permisos", Ordering = 500 },
                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Seguridad > Roles y Permisos > Agregar Rol", Description = "Seguridad > Roles y Permisos > Agregar Rol", Ordering = 501 },
                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Seguridad > Roles y Permisos > Editar Rol", Description = "Seguridad > Roles y Permisos > Editar Rol", Ordering = 502 },
                new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Seguridad > Roles y Permisos > Eliminar Rol", Description = "Seguridad > Roles y Permisos > Eliminar Rol", Ordering = 503 }
            );
        }
    }
}
