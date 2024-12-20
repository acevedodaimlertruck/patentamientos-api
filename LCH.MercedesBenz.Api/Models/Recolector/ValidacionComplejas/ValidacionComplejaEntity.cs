using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas
{
    [Table("ValidacionesComplejas")]
    public class ValidacionComplejaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdValidacionCompleja { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        [StringLength(100)]
        public string? CodValidacionCompleja { get; set; }

        [StringLength(100)]
        public string? CodVersion { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodTipoObjeto { get; set; }

        [StringLength(100)]
        public string? CodEvento { get; set; }

        [StringLength(255)]
        public string? Funcion { get; set; }

        [StringLength(5000)]
        public string? Descripcion { get; set; }
    }
}