using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.FamiliaVisitas.Dtos
{
    public class FamiliaVisitaDto
    {
        [Required]
        [StringLength(100)]
        public string CodFamiliaVisita { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodVisita { get; set; }

        [StringLength(100)]
        public string? CodFamilia { get; set; }

        [StringLength(100)]
        public string? CodVivienda { get; set; }

        public bool? Activo { get; set; }
    }
}