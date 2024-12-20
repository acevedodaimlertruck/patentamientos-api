using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Users.Dtos
{
    public class UserCreateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid RoleId { get; set; }

        [Required]
        [StringLength(64)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [StringLength(64)]
        public string Password { get; set; } = string.Empty;

        [StringLength(8)]
        public string? Pin { get; set; }

        [StringLength(1024)]
        public string? Biometric { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(64)]
        public string Surname { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
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
