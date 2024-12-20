using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Formularios
{
    [Table("Formularios")]
    public class FormularioEntity : BaseRecolectorEntity
    {
        [Key]
        public int IdFormulario { get; set; }

        [Required]
        [StringLength(100)]
        public string CodFormulario { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodSistemaOrigen { get; set; } = string.Empty;

        public bool? FechaMovible { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(1000)]
        public string? Descripcion { get; set; }

        [StringLength(6)]
        public string? Prefijo { get; set; }

        [StringLength(100)]
        public string? CodOrganizacion { get; set; }

        [StringLength(255)]
        public string? Formulario { get; set; }

        [StringLength(500)]
        public string? Objetivo { get; set; }

        [StringLength(500)]
        public string? Archivo { get; set; }

        [StringLength(100)]
        public string? CodDestino { get; set; }
    }
}