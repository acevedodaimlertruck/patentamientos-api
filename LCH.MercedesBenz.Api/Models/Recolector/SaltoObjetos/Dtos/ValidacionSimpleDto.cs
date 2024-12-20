using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos.Dtos
{
    public class ValidacionSimpleDto
    {
        [StringLength(100)]
        public string? CodValidacionSimple { get; set; }

        public bool Requerido { get; set; }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public string? Condicion { get; set; }

        public string? MjeError { get; set; }

        public string? CodPreguntasEnCondicion { get; set; }

        public string? CodPreguntasMostrarMjeError { get; set; }
    }
}