using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Owners.Dtos
{
    public class OwnerDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string CUIT { get; set; } = string.Empty;

        public string CuitPref { get; set; } = string.Empty;
    }
}
