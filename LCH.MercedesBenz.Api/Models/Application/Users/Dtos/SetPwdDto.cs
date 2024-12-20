using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Users.Dtos
{
    public class SetPwdDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string OldPassword { get; set; } = string.Empty;

        [Required]
        [StringLength(1024)]
        public string NewPassword { get; set; } = string.Empty;

        [Required]
        [StringLength(1024)]
        public string RepeatPassword { get; set; } = string.Empty;
    }
}
