using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.SeccionModulos
{
    [Table("Secciones_Modulos")]
    public class SeccionModuloEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdSeccionModulo { get; set; }

        [Required]
        [StringLength(100)]
        public string CodSeccionModulo { get; set; } = string.Empty;

        public bool? Obligatoria { get; set; }

        public bool? Visible { get; set; }

        public bool? Activo { get; set; }

        public int? Orden { get; set; }

        public int? CantBloques { get; set; }

        [StringLength(500)]
        public string? TextoAlternativo { get; set; }

        [StringLength(100)]
        public string? CodSeccionModuloAnterior { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodSeccion { get; set; }

        [StringLength(100)]
        public string? CodModulo { get; set; }
    }
}