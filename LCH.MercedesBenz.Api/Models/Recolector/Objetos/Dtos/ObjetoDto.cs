using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Recolector.Objetos.Dtos
{
    public class ObjetoDto
    {
        public int IdObjeto { get; set; }

        [Required]
        [StringLength(100)]
        public string CodObjeto { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Objeto { get; set; }

        [StringLength(500)]
        public string? Descripcion { get; set; }

        [StringLength(100)]
        public string? Tabla { get; set; }

        [StringLength(100)]
        public string? CampoId { get; set; }

        [StringLength(512)]
        public string? Expresion { get; set; }

        public bool? Activo { get; set; }
    }
}