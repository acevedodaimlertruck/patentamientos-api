using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Segments.Dtos
{
    public class SegmentCreateOrUpdateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        public string? MercedesCategoriaId { get; set; }

        public string? SegName { get; set; }

        public string? DescriptionShort { get; set; }

        public string? DescriptionLong { get; set; }
    }
}
