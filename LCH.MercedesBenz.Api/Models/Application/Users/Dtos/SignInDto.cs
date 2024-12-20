using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Users.Dtos
{
    public class SignInDto
    {
        [Required]
        [StringLength(64)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [StringLength(1024)]
        public string Password { get; set; } = string.Empty;
    }
}
