using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Personas
{
    [Table("Personas")]
    public class PersonaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdPersona { get; set; }

        [Required]
        [StringLength(100)]
        public string CodPersona { get; set; } = string.Empty;

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [StringLength(100)]
        public string? CodSexo { get; set; }

        [StringLength(100)]
        public string? CodTipoDocumento { get; set; }

        [StringLength(50)]
        public string? NroDocumento { get; set; }

        [StringLength(50)]
        public string? NroCuit { get; set; }

        [StringLength(256)]
        public string? LugarNacimiento { get; set; }

        [StringLength(100)]
        public string? CodPaisOrigen { get; set; }

        [StringLength(100)]
        public string? CodEtnia { get; set; }

        [StringLength(100)]
        public string? CodReligion { get; set; }

        [StringLength(100)]
        public string? CodNacionalidad { get; set; }

        [StringLength(100)]
        public string? PerteneceEtnia { get; set; }

        [StringLength(100)]
        public string? CodTipoEstadoCivil { get; set; }

        [StringLength(100)]
        public string? CodTipoDocumentacion { get; set; }

        [StringLength(512)]
        public string? OtraDocumentacion { get; set; }

        [StringLength(100)]
        public string? SabeFechaNacimiento { get; set; }

        [StringLength(100)]
        public string? PoseeDniNuevo { get; set; }

        [StringLength(100)]
        public string? CodVisita { get; set; }

        [StringLength(100)]
        public string? Apellidos { get; set; }

        [StringLength(100)]
        public string? Nombres { get; set; }
    }
}