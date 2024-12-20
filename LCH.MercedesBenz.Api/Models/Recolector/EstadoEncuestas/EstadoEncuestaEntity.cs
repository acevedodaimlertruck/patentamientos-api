using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.EstadoEncuestas
{
    [Table("EstadosEncuesta")]
    public class EstadoEncuestaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdEstadoEncuesta { get; set; }

        [Required]
        [StringLength(100)]
        public string CodEstadoEncuesta { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        [StringLength(50)]
        public string? Es { get; set; }

        [StringLength(100)]
        public string? Tipo { get; set; }

        [StringLength(255)]
        public string? EstadoEncuesta { get; set; }

        [StringLength(500)]
        public string? Descripcion { get; set; }
    }
}