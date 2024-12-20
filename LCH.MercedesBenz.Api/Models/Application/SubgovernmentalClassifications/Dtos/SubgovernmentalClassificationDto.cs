using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications.Dtos
{
    public class SubgovernmentalClassificationDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesSubgovernmentalClassification { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

    }
}
