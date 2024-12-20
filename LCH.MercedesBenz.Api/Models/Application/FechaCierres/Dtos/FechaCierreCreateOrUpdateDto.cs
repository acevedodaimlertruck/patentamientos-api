using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.FechaCierres.Dtos
{
    public class FechaCierreCreateOrUpdateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

    }
}
