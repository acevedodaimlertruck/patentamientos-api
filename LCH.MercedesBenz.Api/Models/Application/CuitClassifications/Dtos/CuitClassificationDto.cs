using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.CuitClassifications.Dtos
{
    public class CuitClassificationDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(2)]
        public string MercedesCuitClassification { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

    }
}
