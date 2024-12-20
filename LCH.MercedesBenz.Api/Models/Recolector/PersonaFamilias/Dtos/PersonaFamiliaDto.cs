using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.PersonaFamilias.Dtos
{
    public class PersonaFamiliaDto
    {
        [Required]
        [StringLength(100)]
        public string CodPersonaFamilia { get; set; } = string.Empty;

        [StringLength(100)]
        public string? CodFamiliaVisita { get; set; }

        [StringLength(100)]
        public string? CodPersona { get; set; }

        public bool? Activo { get; set; }

        public bool? JefeDeHogar { get; set; }

        [StringLength(100)]
        public string? Hogar { get; set; }

        [StringLength(100)]
        public string? CodHogar { get; set; }
    }
}