using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.ColumnaObjetos
{
    [Table("ColumnasObjeto")]
    public class ColumnaObjetoEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdColumnaObjeto { get; set; }

        [Required]
        [StringLength(100)]
        public string CodColumnaObjeto { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodObjeto { get; set; } = string.Empty;

        public bool? Visible { get; set; }

        public bool? Obligatoria { get; set; }

        public bool? VisibleConfiguracion { get; set; }

        public bool? Activo { get; set; }

        public int? Orden { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        [StringLength(100)]
        public string? CodPregunta { get; set; }

        [StringLength(100)]
        public string? Columna { get; set; }

        [StringLength(50)]
        public string? TipoDato { get; set; }
    }
}