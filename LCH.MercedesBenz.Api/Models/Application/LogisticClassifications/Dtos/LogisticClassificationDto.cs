using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.LogisticClassifications.Dtos
{
    public class LogisticClassificationDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesLogisticClassification { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

    }
}
