using LCH.MercedesBenz.Api.Models.Application.Departments;
using Microsoft.EntityFrameworkCore;

public static class DepartmentSeed
{
    public static void SeedDepartments(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasData(
         new Department { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
         );
    }
}