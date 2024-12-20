using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Universal.UsuarioSistemas
{
    [Table("Usuario_Sistema", Schema = "permiso")]
    public class UsuarioSistemaEntity : BaseUniversalEntity
    {
        public bool Activo { get; set; }

        [Key]
        public int IdUsuarioSistema { get; set; }

        [Required]
        [StringLength(100)]
        public string CodUsuario { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodSistema { get; set; } = string.Empty;

        public DateTime? FechaRegistro { get; set; }

        [StringLength(128)]
        public string? CodUsuarioRegistro { get; set; }

        [StringLength(128)]
        public string? CodSistemaRegistro { get; set; }

        [StringLength(100)]
        public string? CodTipoUsuario { get; set; }

        [StringLength(128)]
        public string? CodUsuarioAnterior { get; set; }

        [StringLength(128)]
        public string? CodUsuarioSistema { get; set; }
    }
}
