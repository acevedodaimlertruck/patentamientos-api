using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.OpcionPreguntas.Dtos
{
    public class OpcionPreguntaDto
    {
        [Required]
        [StringLength(100)]
        public string CodOpcionPregunta { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        [StringLength(255)]
        public string? CodOpcion { get; set; }

        [StringLength(500)]
        public string? TextoAlternativo { get; set; }

        public int? Orden { get; set; }

        public bool? Activo { get; set; }

        public bool? DestildaTodo { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }
    }
}