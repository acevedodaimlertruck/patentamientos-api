using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Provinces.Dtos
{
    public class ProvinceDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? MercedesProvinciaId { get; set; }
    }
}
