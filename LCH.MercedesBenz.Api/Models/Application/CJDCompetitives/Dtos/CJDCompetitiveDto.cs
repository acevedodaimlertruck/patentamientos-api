using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.CJDCompetitives.Dtos
{
    public class CJDCompetitiveDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesCJDCompetitive { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
