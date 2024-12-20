using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.OpcionPreguntas
{
    [Table("Opciones_Preguntas")]
    public class OpcionPreguntaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdOpcionPregunta { get; set; }

        [Required]
        [StringLength(100)]
        public string CodOpcionPregunta { get; set; } = string.Empty;

        public bool? DestildaTodo { get; set; }

        public int? Orden { get; set; }

        public int? Activo { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        [StringLength(255)]
        public string? CodOpcion { get; set; }

        [StringLength(500)]
        public string? TextoAlternativo { get; set; }
    }
}