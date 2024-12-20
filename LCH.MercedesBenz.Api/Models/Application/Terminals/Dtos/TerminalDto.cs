using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos
{
    public class TerminalDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? MercedesTerminalId { get; set; }
    }
}
