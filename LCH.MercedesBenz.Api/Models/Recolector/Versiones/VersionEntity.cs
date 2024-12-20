using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Versiones
{
    [Table("Versiones")]
    public class VersionEntity : BaseRecolectorEntity
    {
        public int IdVersion { get; set; }

        public DateTime FechaRegistro { get; set; }

        [Required]
        [StringLength(100)]
        public string CodVersion { get; set; } = string.Empty;

        public bool? Publicar { get; set; }

        public bool? Impactar { get; set; }

        public bool? Activo { get; set; }

        public bool? Unifica { get; set; }

        public DateTime? FechaPublica { get; set; }

        public DateTime? FechaCierre { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        [StringLength(50)]
        [Column("Gps_X")]
        public string? GpsX { get; set; }

        [StringLength(50)]
        [Column("Gps_Y")]
        public string? GpsY { get; set; }

        [StringLength(100)]
        public string? CodFormulario { get; set; }

        [StringLength(255)]
        public string? Version { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        [StringLength(500)]
        public string? MotivoCierre { get; set; }

        [StringLength(100)]
        public string? CodUsuario { get; set; }

        [StringLength(100)]
        public string? CodTipoRelevamiento { get; set; }

        [StringLength(1024)]
        public string? Js { get; set; }

        [StringLength(150)]
        public string? StoreIntermedia { get; set; }

        [StringLength(255)]
        public string? CodFormaSincronizacion { get; set; }
    }
}
