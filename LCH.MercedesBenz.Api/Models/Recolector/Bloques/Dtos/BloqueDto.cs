using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Bloques.Dtos
{
    public class BloqueDto
    {
        [Required]
        [StringLength(100)]
        public string CodBloque { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodSeccion { get; set; }

        [StringLength(500)]
        public string? Bloque { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        [StringLength(500)]
        public string? Js { get; set; }

        public bool? Activo { get; set; }

        [StringLength(100)]
        public string? CodVersion { get; set; }

        [StringLength(100)]
        public string? ButtonLabel { get; set; }

        public bool? Inicial { get; set; }

        public int? CantidadMaxima { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? VerGrilla { get; set; }

        [StringLength(100)]
        public string? CodTipoBloque { get; set; }
    }
}