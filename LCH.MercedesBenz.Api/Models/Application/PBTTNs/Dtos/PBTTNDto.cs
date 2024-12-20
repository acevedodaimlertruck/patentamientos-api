using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.PBTTNs.Dtos
{
    public class PBTTNDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesPBTTN { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
