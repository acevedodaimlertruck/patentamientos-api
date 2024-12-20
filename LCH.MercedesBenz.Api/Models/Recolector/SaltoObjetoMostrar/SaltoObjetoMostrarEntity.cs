using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetoMostrar
{
    [Table("Saltos_Objetos_A_Mostrar")]
    public class SaltoObjetoMostrarEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdSaltoObjetoAMostrar { get; set; }

        public bool? Activo { get; set; }

        public bool? Obligatoria { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(100)]
        public string? CodTipoSalto { get; set; }

        [StringLength(100)]
        [Column("CodOpcionAMostrar")]
        public string? CodOpcionMostrar { get; set; }

        [StringLength(100)]
        [Column("CodSaltoObjetoAMostrar")]
        public string? CodSaltoObjetoMostrar { get; set; }

        [StringLength(100)]
        public string? CodSaltoObjeto { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodEstadoEncuesta { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }
    }
}