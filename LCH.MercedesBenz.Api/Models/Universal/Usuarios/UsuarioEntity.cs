using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Universal.Usuarios
{
    [Table("Usuarios", Schema = "permiso")]
    public class UsuarioEntity : BaseUniversalEntity
    {
        public bool Activo { get; set; }

        [Key]
        public int IdUsuario { get; set; }

        public byte[] Pass { get; set; }

        [Required]
        [StringLength(100)]
        public string CodUsuario { get; set; } = string.Empty;

        public bool? Verificado { get; set; }

        public bool? PermisoFicha { get; set; }

        public bool? RequestedPasswordReset { get; set; }

        public bool? PaswordResetBlocked { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [Column("__createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }

        [Column("__updatedAt")]
        public DateTimeOffset? UpdatedAt { get; set; }

        public int? PasswordResetAttempts { get; set; }

        public byte[]? PassOffline { get; set; }

        [StringLength(50)]
        public string? Usuario { get; set; }

        [StringLength(100)]
        public string? Nic { get; set; }

        [StringLength(6)]
        public string? CodVerificacion { get; set; }

        [StringLength(6)]
        public string? TempPassword { get; set; }
    }
}
