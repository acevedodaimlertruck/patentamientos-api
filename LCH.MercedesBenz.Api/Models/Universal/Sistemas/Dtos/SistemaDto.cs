using LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Universal.Sistemas.Dtos
{
    public class SistemaDto
    {
        public int IdSistema { get; set; }

        [Required]
        [StringLength(100)]
        public string CodSistema { get; set; } = string.Empty;

        [StringLength(3)]
        public string? Prefijo { get; set; }

        [StringLength(256)]
        public string? PathPerfil { get; set; }

        [StringLength(128)]
        public string? Sistema { get; set; }

        [StringLength(512)]
        public string? Url { get; set; }

        [StringLength(512)]
        public string? PathMultimedia { get; set; }

        [StringLength(10)]
        public string? PuertoMultimedia { get; set; }

        [StringLength(512)]
        public string? PathExtras { get; set; }

        [StringLength(256)]
        public string? Descripcion { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public TipoUsuarioDto? TipoUsuario { get; set; }
    }
}
