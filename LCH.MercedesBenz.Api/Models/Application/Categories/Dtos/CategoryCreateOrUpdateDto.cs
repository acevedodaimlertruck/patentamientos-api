namespace LCH.MercedesBenz.Api.Models.Application.Categories.Dtos
{
    public class CategoryCreateOrUpdateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        public string? SegCategory { get; set; }

        public string? Description { get; set; }
    }
}
