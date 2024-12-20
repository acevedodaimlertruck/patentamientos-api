using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.PBTs.Dtos
{
    public class PBTDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesPBT { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
