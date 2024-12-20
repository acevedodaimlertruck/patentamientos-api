using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos
{
    public class VisitaDto
    {
        [Required]
        [StringLength(100)]
        public string CodVisita { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Alias { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public int? Tiempo { get; set; }

        [StringLength(255)]
        public string? EstadoEncuesta { get; set; }

        [StringLength(100)]
        public string? CodUsuario { get; set; }

        [StringLength(256)]
        public string? Usuario { get; set; }
    }
}