using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.PersonaFamilias
{
    [Table("Personas_Familias")]
    public class PersonaFamiliaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdPersonaFamilia { get; set; }

        [Required]
        [StringLength(100)]
        public string CodPersonaFamilia { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        public bool? JefeDeHogar { get; set; }

        [StringLength(100)]
        public string? Hogar { get; set; }

        [StringLength(100)]
        public string? CodHogar { get; set; }

        [StringLength(100)]
        public string? CodFamiliaVisita { get; set; }

        [StringLength(100)]
        public string? CodPersona { get; set; }
    }
}