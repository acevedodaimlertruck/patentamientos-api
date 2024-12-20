using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.DatoGeometricos
{
    [Table("DatoGeometrico")]
    public class DatoGeometricoEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdDatoGeometrico { get; set; }

        [Required]
        [StringLength(100)]
        public string CodSeccionModulo { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodOpcionPregunta { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(100)]
        public string? CodGeometrico { get; set; }

        [StringLength(100)]
        public string? CodColor { get; set; }
    }
}