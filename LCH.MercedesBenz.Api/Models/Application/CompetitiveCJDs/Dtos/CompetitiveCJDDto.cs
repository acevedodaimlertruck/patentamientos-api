using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs.Dtos
{
    public class CompetitiveCJDDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesCompetitiveCJD { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}
