using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Users.Dtos
{
    public class SignInWithPinDto
    {
        [Required]
        [StringLength(64)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [StringLength(8)]
        public string Pin { get; set; } = string.Empty;
    }
}
