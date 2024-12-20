using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Respuestas
{
    [Table("Respuestas")]
    public class RespuestaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdRespuesta { get; set; }

        [Required]
        [StringLength(100)]
        public string CodRespuesta { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodVersion { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(100)]
        public string? TipoDatoCodigo { get; set; }

        [StringLength(100)]
        public string? CodVisita { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        [StringLength(100)]
        public string? CodDetallePregunta { get; set; }

        [StringLength(255)]
        public string? CodOpcion { get; set; }

        [StringLength(100)]
        public string? CodEntidad { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(8000)]
        public string? RespuestaAlfanumerico { get; set; }

        [StringLength(255)]
        public string? Agrupamiento { get; set; }
    }
}