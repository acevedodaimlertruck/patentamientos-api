using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Formularios.Dtos
{
    public class Formulario2Dto
    {
        [Required]
        [StringLength(100)]
        public string CodFormulario { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Formulario { get; set; }

        [StringLength(1000)]
        public string? Sistema { get; set; }

        [StringLength(6)]
        public string? FechaRegistroR { get; set; }
    }
}