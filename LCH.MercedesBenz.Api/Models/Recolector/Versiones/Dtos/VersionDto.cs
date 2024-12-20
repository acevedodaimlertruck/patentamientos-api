using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos
{
    public class VersionDto
    {
        [Required]
        [StringLength(100)]
        public string CodVersion { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodFormulario { get; set; }

        [StringLength(255)]
        public string? Version { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(100)]
        public string? CodTipoRelevamiento { get; set; }

        [StringLength(1024)]
        public string? Js { get; set; }

        public bool? Activo { get; set; }
    }
}
