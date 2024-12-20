using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos
{
    public class CarModelCreateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? MercedesTerminalId { get; set; }

        public string? MercedesMarcaId { get; set; }

        public string? MercedesModeloId { get; set; }
    }
}
