using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Recolector.Modulos.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Formularios.Dtos
{
    public class FormularioDto
    {
        public int IdFormulario { get; set; }

        [Required]
        [StringLength(100)]
        public string CodFormulario { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodSistemaOrigen { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Formulario { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        [StringLength(6)]
        public string? Prefijo { get; set; }

        [StringLength(100)]
        public string? CodOrganizacion { get; set; }

        public VersionDto? Version { get; set; }

        public ICollection<ModuloDto> Modulos { get; set; } = new List<ModuloDto>();
    }
}