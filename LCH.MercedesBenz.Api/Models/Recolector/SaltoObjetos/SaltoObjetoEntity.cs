using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos
{
    [Table("Saltos_Objetos")]
    public class SaltoObjetoEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdSaltoObjeto { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [StringLength(-1)]
        public string? Comentario { get; set; }

        [StringLength(100)]
        public string? CodUsuario { get; set; }

        [StringLength(100)]
        public string? CodSaltoObjeto { get; set; }

        [StringLength(100)]
        public string? CodVersion { get; set; }

        [StringLength(-1)]
        public string? Condicion { get; set; }

        [StringLength(-1)]
        public string? DescripcionSalto { get; set; }
    }
}