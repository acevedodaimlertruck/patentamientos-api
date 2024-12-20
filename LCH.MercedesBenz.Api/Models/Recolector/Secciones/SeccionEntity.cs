using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Secciones
{
    [Table("Secciones")]
    public class SeccionEntity
    {
        [Key]
        public int IdSeccion { get; set; }

        [Required]
        [StringLength(100)]
        public string CodSeccion { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Seccion { get; set; } = string.Empty;

        public bool? EsFormulario { get; set; }

        public bool? Activo { get; set; }

        public int? CodPadre { get; set; }

        [StringLength(256)]
        [Column("tagname")]
        public string? Tagname { get; set; }

        [StringLength(500)]
        public string? Descripcion { get; set; }
    }
}