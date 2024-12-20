using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas
{
    [Table("Visitas")]
    public class VisitaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdVisita { get; set; }

        [Required]
        [StringLength(100)]
        public string CodVisita { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodSistema { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodVersion { get; set; } = string.Empty;

        public bool? Procesado { get; set; }

        public bool? Reporte { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public int? Tiempo { get; set; }

        public int? Distancia { get; set; }

        [StringLength(100)]
        public string? CodEstadoEncuesta { get; set; }

        [StringLength(50)]
        [Column("GPS_X")]
        public string? GpsX { get; set; }

        [StringLength(50)]
        [Column("GPS_Y")]
        public string? GpsY { get; set; }

        [StringLength(100)]
        public string? Alias { get; set; }

        [StringLength(100)]
        public string? CodSede { get; set; }

        [StringLength(100)]
        public string? CodEstadoProceso { get; set; }

        [StringLength(100)]
        public string? Dispositivo { get; set; }

        [StringLength(100)]
        public string? Usuario { get; set; }

        [StringLength(100)]
        public string? CodSalida { get; set; }

        [StringLength(100)]
        public string? CodSalidaFormulario { get; set; }

        [StringLength(100)]
        public string? NombreVisita { get; set; }

        [StringLength(100)]
        public string? CodVisitaOrigen { get; set; }
    }
}