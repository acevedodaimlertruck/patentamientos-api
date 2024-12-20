using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.EngineCapacitys.Dtos
{
    public class EngineCapacityDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesEngineCapacity { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
