using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers.Dtos
{
    public class EstimatedTurnoverDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesEstimatedTurnover { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

    }
}
