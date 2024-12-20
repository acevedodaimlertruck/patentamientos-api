using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s.Dtos
{
    public class SegmentationAux1Dto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesSegmentationAux1 { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
