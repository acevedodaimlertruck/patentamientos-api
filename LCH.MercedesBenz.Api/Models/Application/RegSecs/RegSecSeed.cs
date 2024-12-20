using LCH.MercedesBenz.Api.Models.Application.RegSecs;
using Microsoft.EntityFrameworkCore;

public static class RegSecSeed
{
    public static void SeedRegSecs(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegSec>().HasData(
             //new RegSec { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
new RegSec { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO", /*ProvinceId = Guid.Parse("00000000-0000-0000-0000-000000000033"), DepartmentId = Guid.Parse("00000000-0000-0000-0000-000000000033"), LocationId = Guid.Parse("00000000-0000-0000-0000-000000000033")*/ }
);
    }
}