using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos.Dtos
{
    public class SaltoObjetoDto
    {
        [StringLength(100)]
        public string? CodSaltoObjeto { get; set; }

        [StringLength(100)]
        public string? CodTipoSalto { get; set; }

        public string? Condicion { get; set; }

        [StringLength(100)]
        public string? CodModulo { get; set; }

        [StringLength(100)]
        public string? CodSeccionModulo { get; set; }

        public string? CodObjetosInvolucrados { get; set; }

        public string? CodObjetosMostrar { get; set; }

        public string? CodOpcionesMostrar { get; set; }

        public bool? Obligatoria { get; set; }
    }
}