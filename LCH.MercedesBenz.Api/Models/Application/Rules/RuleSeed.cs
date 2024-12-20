using LCH.MercedesBenz.Api.Models.Application.Rules;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Rules
{
    public static class RulePatentingSeed
    {
        public static void SeedRules(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rule>().HasData(
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "OFMM No Existente", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "01" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Fecha Atrasada en un año", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "02" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Mes Fecha Inscripción mayor al mes de la fecha de corte", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "03" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Dominio duplicado ya ha sido cargado", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "04" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Chasis duplicado ya ha sido cargado", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "05" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Dominio duplicado en el mismo archivo", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "06" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "No existe MMG", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Code = "07" },
                new Rule { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Chasis en blanco", RuleTypeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Code = "08" }
                );
        }
    }
}
