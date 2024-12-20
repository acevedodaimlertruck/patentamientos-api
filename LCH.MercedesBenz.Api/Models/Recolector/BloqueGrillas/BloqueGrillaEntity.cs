using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.BloqueGrillas
{
    [Table("Bloques_Grilla")]
    public class BloqueGrillaEntity : BaseRecolectorEntity
    {
        [Key]
        [Column("IdBG")]
        public int IdBloqueGrilla { get; set; }

        [StringLength(100)]
        [Column("CodBG")]
        public string? CodBloqueGrilla { get; set; }

        [StringLength(100)]
        public string? CodBloque { get; set; }

        [StringLength(100)]
        public string? CodPreguntaSeccion { get; set; }

        public int? Orden { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Activo { get; set; }
    }
}