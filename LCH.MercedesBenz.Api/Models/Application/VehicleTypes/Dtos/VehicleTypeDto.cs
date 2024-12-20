using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos
{
    public class VehicleTypeDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
