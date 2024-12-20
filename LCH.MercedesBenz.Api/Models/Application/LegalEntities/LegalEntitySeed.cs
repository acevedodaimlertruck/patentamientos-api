using LCH.MercedesBenz.Api.Models.Application.LegalEntities;
using Microsoft.EntityFrameworkCore;

public static class LegalEntitySeed
{
    public static void SeedLegalEntities(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LegalEntity>().HasData(
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MercedesLegalEntity = "AS", DescriptionShort = "Asociación Civil", DescriptionLong = "Asociación Civil" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), MercedesLegalEntity = "CN", DescriptionShort = "Consorcio Prop Horiz", DescriptionLong = "Consorcio de Propiedad Horizontal" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), MercedesLegalEntity = "CO", DescriptionShort = "Cooperativa", DescriptionLong = "Cooperativa" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), MercedesLegalEntity = "ESE", DescriptionShort = "Estado Extranjero", DescriptionLong = "Persona Estado Extranjero" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), MercedesLegalEntity = "ESN", DescriptionShort = "Estado", DescriptionLong = "Estado" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), MercedesLegalEntity = "IC", DescriptionShort = "Iglesia Católica", DescriptionLong = "Iglesia Católica" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), MercedesLegalEntity = "IG", DescriptionShort = "Iglesia", DescriptionLong = "Iglesia" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), MercedesLegalEntity = "MU", DescriptionShort = "Mutual", DescriptionLong = "Mutual" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), MercedesLegalEntity = "SA", DescriptionShort = "Sociedad Anónima", DescriptionLong = "Sociedad Anónima" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), MercedesLegalEntity = "SAE", DescriptionShort = "SA c/Part Est Mayori", DescriptionLong = "Sociedad Anónima con Participación Estatal Mayoritaria" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), MercedesLegalEntity = "SAU", DescriptionShort = "Soc. An. Unipersonal", DescriptionLong = "Sociedad Anónima Unipersonal" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), MercedesLegalEntity = "SC", DescriptionShort = "Sociedad Civil", DescriptionLong = "Sociedad Civil" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), MercedesLegalEntity = "SE", DescriptionShort = "Sociedad del Estado", DescriptionLong = "Sociedad del Estado" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), MercedesLegalEntity = "SH", DescriptionShort = "Sociedad de Hecho", DescriptionLong = "Sociedad de Hecho" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), MercedesLegalEntity = "SRL", DescriptionShort = "Soc. Resp. Limitada", DescriptionLong = "Sociedad de Responsabilidad Limitada" },
         new LegalEntity { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), MercedesLegalEntity = "NOA", DescriptionShort = "NOASIGNADO", DescriptionLong = "NOASIGNADO" }
        );

    }
}