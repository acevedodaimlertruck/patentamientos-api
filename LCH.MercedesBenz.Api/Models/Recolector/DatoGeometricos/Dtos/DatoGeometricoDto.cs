using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.DatoGeometricos.Dtos
{
    public class DatoGeometricoDto
    {
        [Required]
        [StringLength(100)]
        public string CodSeccionModulo { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodOpcionPregunta { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodGeometrico { get; set; }

        [StringLength(100)]
        public string? CodColor { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Activo { get; set; }
    }
}