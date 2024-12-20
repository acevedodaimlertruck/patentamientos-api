using LCH.MercedesBenz.Api.Models.Recolector.SeccionModulos.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Modulos.Dtos
{
    public class ModuloDto
    {
        public int IdModulo { get; set; }

        [Required]
        [StringLength(100)]
        public string CodModulo { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodVersion { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Modulo { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        public int Orden { get; set; }

        public bool? ConHistorial { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        public ICollection<SeccionModuloDto> SeccionesModulo { get; set; } = new List<SeccionModuloDto>();
    }
}