using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Recolector.Opciones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.PreguntasSeccion.Dtos
{
    public class PreguntaSeccionDto
    {
        [Required]
        [StringLength(100)]
        public string CodPreguntaSeccion { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodTipoDato { get; set; }

        [StringLength(100)]
        public string? CodBloque { get; set; }

        [StringLength(100)]
        public string? CodPregunta { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        public int? Orden { get; set; }

        [StringLength(255)]
        public string? Identificacion { get; set; }

        [StringLength(500)]
        public string? TextoAlternativo { get; set; }

        [StringLength(500)]
        public string? ValorDefecto { get; set; }

        [StringLength(1000)]
        public string? Ayuda { get; set; }

        public bool? Obligatoria { get; set; }

        public bool? Visible { get; set; }

        public int? TamanioHtml { get; set; }

        [StringLength(100)]
        public string? TipoCampo { get; set; }

        [StringLength(100)]
        public string? Mascara { get; set; }

        [StringLength(20)]
        public string? Orientacion { get; set; }

        [StringLength(500)]
        public string? Javascript { get; set; }

        [StringLength(100)]
        public string? CodPreguntaAux { get; set; }

        public bool? MostrarOrdenOpcion { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? TablaDestino { get; set; }

        [StringLength(100)]
        public string? CampoDestino { get; set; }

        [StringLength(255)]
        public string? Metodo { get; set; }

        public bool? Recargable { get; set; }

        public int? Duracion { get; set; }

        public bool? Historial { get; set; }

        public bool? Lectura { get; set; }

        public bool? ClaveBusqueda { get; set; }

        public bool? Restrictiva { get; set; }

        public bool ModificaEntidad { get; set; }

        [StringLength(100)]
        public string? Pivots { get; set; }

        [StringLength(8)]
        public string? CodTipoBloque { get; set; }

        public List<OpcionDto> Opciones { get; set; } = new List<OpcionDto>();
    }
}