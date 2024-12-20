using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Modulos
{
    [Table("Modulos")]
    public class ModuloEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdModulo { get; set; }

        public int Orden { get; set; }

        [Required]
        [StringLength(100)]
        public string CodModulo { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        public bool? ConHistorial { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodModuloAnterior { get; set; }

        [StringLength(20)]
        public string? IterarModulo { get; set; }

        [StringLength(100)]
        public string? CodVersion { get; set; }

        [StringLength(255)]
        public string? Modulo { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }
    }
}