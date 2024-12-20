using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.PreguntaSecciones
{
    [Table("Preguntas_Secciones")]
    public class PreguntaSeccionEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdPreguntaSeccion { get; set; }

        [Required]
        [StringLength(100)]
        public string CodPreguntaSeccion { get; set; } = string.Empty;

        public bool? Obligatoria { get; set; }

        public bool? Visible { get; set; }

        public bool? MostrarOrdenOpcion { get; set; }

        public bool? Historial { get; set; }

        public bool? Lectura { get; set; }

        public bool? ClaveBusqueda { get; set; }

        public bool? Restrictiva { get; set; }

        public bool? Recargable { get; set; }

        public bool? EdicionMasiva { get; set; }

        public int? Duracion { get; set; }

        public int? Activo { get; set; }

        public int? TamanioHtml { get; set; }

        public int? Orden { get; set; }

        [StringLength(255)]
        public string? Identificacion { get; set; }

        [StringLength(500)]
        public string? TextoAlternativo { get; set; }

        [StringLength(500)]
        public string? ValorDefecto { get; set; }

        [StringLength(1000)]
        public string? Ayuda { get; set; }

        [StringLength(100)]
        public string? CodTipoDato { get; set; }

        [StringLength(100)]
        public string? CodBloque { get; set; }

        [StringLength(100)]
        public string? CodPregunta { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

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

        [StringLength(255)]
        [Column("codAccion")]
        public string? CodAccion { get; set; }

        [StringLength(1024)]
        public string? Configuracion { get; set; }

        [StringLength(100)]
        public string? CodBloqueDependencia { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? TablaDestino { get; set; }

        [StringLength(100)]
        public string? CampoDestino { get; set; }

        [StringLength(255)]
        public string? Metodo { get; set; }
    }
}