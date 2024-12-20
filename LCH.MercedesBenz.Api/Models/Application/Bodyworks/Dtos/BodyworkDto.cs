using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Bodyworks.Dtos
{
    public class BodyworkDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesBodywork { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
