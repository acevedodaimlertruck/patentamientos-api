using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Factories.Dtos
{
    public class FactoryDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? MercedesFabricaId { get; set; }
    }
}
