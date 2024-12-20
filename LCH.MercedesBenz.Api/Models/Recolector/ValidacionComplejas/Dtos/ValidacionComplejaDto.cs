using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas.Dtos
{
    public class ValidacionComplejaDto
    {
        public int IdValidacionCompleja { get; set; }

        [StringLength(100)]
        public string? CodValidacionCompleja { get; set; }

        [StringLength(100)]
        public string? CodVersion { get; set; }

        [StringLength(100)]
        public string? CodObjeto { get; set; }

        [StringLength(100)]
        public string? CodTipoObjeto { get; set; }

        [StringLength(100)]
        public string? CodEvento { get; set; }

        [StringLength(255)]
        public string? Funcion { get; set; }

        [StringLength(5000)]
        public string? Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}