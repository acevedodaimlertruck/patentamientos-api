using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Secciones.Dtos
{
    public class SeccionDto
    {
        [Required]
        [StringLength(100)]
        public string CodSeccion { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Seccion { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Descripcion { get; set; }
    }
}