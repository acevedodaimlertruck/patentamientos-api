using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.FamiliaVisitas
{
    [Table("Familias_Visitas")]
    public class FamiliaVisitaEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdFamiliaVisita { get; set; }

        [Required]
        [StringLength(100)]
        public string CodFamiliaVisita { get; set; } = string.Empty;

        public bool? Activo { get; set; }

        [StringLength(100)]
        public string? CodVisita { get; set; }

        [StringLength(100)]
        public string? CodFamilia { get; set; }

        [StringLength(100)]
        public string? CodVivienda { get; set; }
    }
}