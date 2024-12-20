using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications.Dtos
{
    public class GovernmentalClassificationDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(2)]
        public string MercedesGovernmentalClassification { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

    }
}
