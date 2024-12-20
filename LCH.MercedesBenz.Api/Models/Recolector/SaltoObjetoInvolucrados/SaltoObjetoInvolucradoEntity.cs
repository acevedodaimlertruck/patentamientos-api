using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetoInvolucrados
{
    [Table("Saltos_Objetos_Involucrados")]
    public class SaltoObjetoInvolucradoEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdSaltoObjetoInvolucrado { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(1024)]
        public string? CodOpcionesInvolucradas { get; set; }

        [StringLength(100)]
        public string? CodSaltoObjetoInvolucrado { get; set; }

        [StringLength(100)]
        public string? CodSaltoObjeto { get; set; }

        [StringLength(100)]
        public string? CodObjetoInvolucrado { get; set; }
    }
}