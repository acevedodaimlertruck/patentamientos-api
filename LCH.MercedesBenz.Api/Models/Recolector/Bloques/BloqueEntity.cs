using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Bloques
{
    [Table("Bloques")]
    public class BloqueEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdBloque { get; set; }

        [Required]
        [StringLength(100)]
        public string CodBloque { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        public bool? Inicial { get; set; }

        public bool? VerGrilla { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? CantidadMaxima { get; set; }

        [StringLength(100)]
        public string? CodVersion { get; set; }

        [StringLength(100)]
        public string? ButtonLabel { get; set; }

        [StringLength(100)]
        public string? CodSeccion { get; set; }

        [StringLength(500)]
        public string? Bloque { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        [StringLength(500)]
        public string? Js { get; set; }

        [StringLength(100)]
        public string? CodTipoBloque { get; set; }
    }
}