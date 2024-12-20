using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Objetos
{
    [Table("Objetos")]
    public class ObjetoEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdObjeto { get; set; }

        [Required]
        [StringLength(100)]
        public string CodObjeto { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        [StringLength(100)]
        public string? Objeto { get; set; }

        [StringLength(500)]
        public string? Descripcion { get; set; }

        [StringLength(100)]
        public string? Tabla { get; set; }

        [StringLength(100)]
        public string? CampoId { get; set; }

        [StringLength(512)]
        public string? Expresion { get; set; }
    }
}