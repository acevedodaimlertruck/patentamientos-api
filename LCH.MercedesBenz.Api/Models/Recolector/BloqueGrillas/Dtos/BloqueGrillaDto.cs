using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.BloqueGrillas.Dtos
{
    public class BloqueGrillaDto
    {
        [StringLength(100)]
        public string? CodBloqueGrilla { get; set; }

        [StringLength(100)]
        public string? CodBloque { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        public int? Orden { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Activo { get; set; }
    }
}