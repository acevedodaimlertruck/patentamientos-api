using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Terminals
{
    public static class TerminalSeed
    {
        public static void SeedTerminals(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Terminal>().HasData(
                new Terminal { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "NOASIGNADO", Description = "NOASIGNADO" }
            );
        }
    }
}
