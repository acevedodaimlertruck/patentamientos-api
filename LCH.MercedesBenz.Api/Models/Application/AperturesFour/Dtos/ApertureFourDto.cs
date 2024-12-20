using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureFours.Dtos
{
    public class ApertureFourDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesApertureFour { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
