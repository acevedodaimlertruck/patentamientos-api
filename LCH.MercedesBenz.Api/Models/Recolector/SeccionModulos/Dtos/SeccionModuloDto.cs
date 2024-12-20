using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Recolector.Secciones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.SeccionModulos.Dtos
{
    public class SeccionModuloDto
    {
        [Required]
        [StringLength(100)]
        public string CodSeccionModulo { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodSeccion { get; set; }

        [StringLength(100)]
        public string? CodModulo { get; set; }

        public bool? Obligatoria { get; set; }

        public bool? Visible { get; set; }

        public int? Orden { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        public int? CantBloques { get; set; }

        [StringLength(500)]
        public string? TextoAlternativo { get; set; }

        public SeccionDto? Seccion { get; set; }
    }
}