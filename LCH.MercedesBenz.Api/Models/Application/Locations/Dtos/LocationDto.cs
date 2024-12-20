using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Locations.Dtos
{
    public class LocationDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? MercedesProvinciaId { get; set; }

        public string? MercedesDepartamentoId { get; set; }

        public string? MercedesLocalidadId { get; set; }

    }
}
