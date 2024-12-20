using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetoInvolucrados.Dtos
{
    public class SaltoObjetoInvolucradoDto
    {
        [StringLength(100)]
        public string? CodSaltoObjetoInvolucrado { get; set; }

        [StringLength(100)]
        public string? CodSaltoObjeto { get; set; }

        [StringLength(100)]
        public string? CodObjetoInvolucrado { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Activo { get; set; }

        [StringLength(1024)]
        public string? CodOpcionesInvolucradas { get; set; }
    }
}