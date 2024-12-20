using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Universal.UsuarioOrganizaciones
{
    [Table("Usuario_Organizacion")]
    public class UsuarioOrganizacionEntity : BaseUniversalEntity
    {
        [Key]
        public int IdUsuarioOrganizacion { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        [StringLength(100)]
        public string? CodUsuarioModifico { get; set; }

        [StringLength(100)]
        public string? CodUsuario { get; set; }

        [StringLength(100)]
        public string? CodOrganizacion { get; set; }

        [StringLength(100)]
        public string? CodUsuarioOrganizacion { get; set; }
    }
}
