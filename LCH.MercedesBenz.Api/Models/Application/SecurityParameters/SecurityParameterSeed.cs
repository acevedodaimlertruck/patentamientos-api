using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.SecurityParameters
{
    public static class SecurityParameterSeed
    {
        public static void SeedSecurityParameters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SecurityParameter>().HasData(
                new SecurityParameter {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    SessionTime = 3,
                    NumberLogins = 3,
                    MinCharacters = 6,
                    MaxCharacters = 12,
                    IncludeCapitalLetter = true,
                    IncludeNumbers = true,
                    IncludeSpecialCharacters = true,
                }
            );
        }
    }
}
