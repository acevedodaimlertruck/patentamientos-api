﻿using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureThrees.Dtos
{
    public class ApertureThreeDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesApertureThree { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

    }
}