using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Owners
{
    public static class OwnerSeed
    {
        public static void SeedOwners(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(
            new Owner { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), FullName = "NOASIGNADO" }
            );
        }
    }
}
