using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios.Dtos
{
    public class TipoUsuarioDto
    {
        [Required]
        [StringLength(100)]
        public string CodTipoUsuario { get; set; } = string.Empty;

        [StringLength(100)]
        public string? TipoUsuario { get; set; }
    }
}
