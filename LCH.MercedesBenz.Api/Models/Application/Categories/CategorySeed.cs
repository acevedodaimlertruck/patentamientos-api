using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Categories
{
    public static class CategorySeed
    {
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), SegCategory = "NOA", Description = "NOASIGNADO" }
                );
        }
    }
}
