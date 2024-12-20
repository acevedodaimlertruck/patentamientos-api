using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos
{
    public class CarModelDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public Guid BrandId { get; set; }

        public BrandDto? Brand { get; set; }

        [StringLength(256)]
        public string? MercedesTerminalId { get; set; }

        public string? MercedesMarcaId { get; set; }

        public string? MercedesModeloId { get; set; }
    }
}
