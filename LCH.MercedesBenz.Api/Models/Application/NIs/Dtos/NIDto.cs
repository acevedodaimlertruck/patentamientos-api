using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.NIs.Dtos
{
    public class NIDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesNI { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
