using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Universal.Sistemas
{
    [Table("Sistemas", Schema = "catalogo")]
    public class SistemaEntity : BaseUniversalEntity
    {
        [Key]
        public int IdSistema { get; set; }

        [Required]
        [StringLength(100)]
        public string CodSistema { get; set; } = string.Empty;

        public bool? Activo { get; set; }

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
    }
}
