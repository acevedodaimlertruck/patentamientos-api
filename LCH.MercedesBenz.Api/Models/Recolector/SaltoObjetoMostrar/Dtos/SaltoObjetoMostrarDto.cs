using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetoMostrar.Dtos
{
    public class SaltoObjetoMostrarDto
    {
        [StringLength(100)]
        public string? CodSaltoObjetoMostrar { get; set; }

        [StringLength(100)]
        public string? CodSaltoObjeto { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodEstadoEncuesta { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Activo { get; set; }

        [StringLength(100)]
        public string? CodTipoSalto { get; set; }

        [StringLength(100)]
        public string? CodOpcionMostrar { get; set; }

        public bool? Obligatoria { get; set; }
    }
}