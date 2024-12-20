using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Users
{
    public static class UserSeed
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<User>();
            var user = new User
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UserName = "superadmin",
                Name = "Super",
                Surname = "Admin",
                Birthdate = DateTime.Parse("1990-01-01"),
                RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            };
            var usuario = new User
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                UserName = "usuario",
                Name = "Usuario",
                Surname = "Usuario",
                Birthdate = DateTime.Parse("1996-07-30"),
                RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            };
            user.Password = UserRepository.GetBytesFromValue("kZK06q3k94mH");
            usuario.Password = UserRepository.GetBytesFromValue("password");
            modelBuilder.Entity<User>().HasData(
                user, usuario
            );
        }
    }
}
