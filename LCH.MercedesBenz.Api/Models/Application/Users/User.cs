using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Roles;

namespace LCH.MercedesBenz.Api.Models.Application.Users
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid RoleId { get; set; }

        [JsonIgnore]
        public virtual Role? Role { get; set; }

        [Required]
        [StringLength(64)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public byte[]? Password { get; set; }

        public byte[]? Pin { get; set; }

        public byte[]? Biometric { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(64)]
        public string Surname { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? Birthdate { get; set; }

        [StringLength(128)]
        public string? Email { get; set; }

        [StringLength(4)]
        public string? PhoneCountryCode { get; set; }

        [StringLength(4)]
        public string? PhoneAreaCode { get; set; }

        [StringLength(16)]
        public string? PhoneNumber { get; set; }

        [StringLength(32)]
        public string? FullPhoneNumber { get; set; }

        [StringLength(1024)]
        public string? Photo { get; set; }

        [Required]
        [StringLength(16)]
        public string Dni { get; set; } = string.Empty;
    }
}
