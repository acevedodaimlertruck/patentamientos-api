using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios
{
    [Table("TiposUsuarios", Schema = "permiso")]
    public class TipoUsuarioEntity : BaseUniversalEntity
    {
        [Key]
        public int IdTipoUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string CodTipoUsuario { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        [StringLength(100)]
        public string? TipoUsuario { get; set; }
    }
}
