using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.ColumnaObjetos.Dtos
{
    public class ColumnaObjetoDto
    {
        [Required]
        [StringLength(100)]
        public string CodColumnaObjeto { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodObjeto { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodPregunta { get; set; }

        [StringLength(100)]
        public string? Columna { get; set; }

        [StringLength(50)]
        public string? TipoDato { get; set; }

        public bool? Visible { get; set; }

        public int? Orden { get; set; }

        public bool? Obligatoria { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        public bool? VisibleConfiguracion { get; set; }

        public bool? Activo { get; set; }
    }
}