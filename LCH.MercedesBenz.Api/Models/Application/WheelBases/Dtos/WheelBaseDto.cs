using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.WheelBases.Dtos
{
    public class WheelBaseDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesWheelBase { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
