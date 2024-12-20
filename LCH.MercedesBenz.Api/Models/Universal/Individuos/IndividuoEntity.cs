using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Universal.Individuos
{
    [Table("Individuos")]
    public class IndividuoEntity : BaseUniversalEntity
    {
        public bool Activo { get; set; }

        [Key]
        public int IdIndividuo { get; set; }

        [Required]
        [StringLength(100)]
        public string CodPersona { get; set; } = string.Empty;

        public bool? IsVerified { get; set; }

        public bool? EmailVerificationBlocked { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaBaja { get; set; }

        [Column("__createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }

        [Column("__updatedAt")]
        public DateTimeOffset? UpdatedAt { get; set; }

        public int? EmailVerificationAttempts { get; set; }

        [StringLength(100)]
        public string? CodSistema { get; set; }

        [StringLength(100)]
        public string? Cuil { get; set; }

        [StringLength(100)]
        public string? Cuit { get; set; }

        [StringLength(100)]
        public string? CodSexo { get; set; }

        [StringLength(100)]
        [Column("CP")]
        public string? Cp { get; set; }

        [StringLength(100)]
        public string? CodVivienda { get; set; }

        [StringLength(500)]
        public string? PathFoto { get; set; }

        [StringLength(6)]
        public string? EmailVerificationCode { get; set; }

        [StringLength(128)]
        public string? Mail { get; set; }

        [StringLength(50)]
        public string? Telefono1 { get; set; }

        [StringLength(50)]
        public string? Telefono2 { get; set; }

        [StringLength(50)]
        [Column("IMEI")]
        public string? Imei { get; set; }

        [StringLength(512)]
        public string? Domicilio { get; set; }

        [StringLength(100)]
        public string? Apellido { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(128)]
        public string? Foto { get; set; }

        [StringLength(128)]
        public string? TipoDocumento { get; set; }

        [StringLength(50)]
        [Column("DNI")]
        public string? Dni { get; set; }
    }
}
