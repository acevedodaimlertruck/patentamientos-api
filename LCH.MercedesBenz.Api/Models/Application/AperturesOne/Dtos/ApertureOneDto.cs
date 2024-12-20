using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos
{
    public class ApertureOneDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesApertureOne { get; set; } = string.Empty;
        [StringLength(3)]
        public string? SegCategory { get; set; }

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

    }
}
