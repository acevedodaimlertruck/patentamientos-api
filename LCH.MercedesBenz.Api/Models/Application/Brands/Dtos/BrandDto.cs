using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Brands.Dtos
{
    public class BrandDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public Guid TerminalId { get; set; }

        public TerminalDto? Terminal { get; set; }

        public string? MercedesTerminalId { get; set; }

        public string? MercedesMarcaId { get; set; }
    }
}
