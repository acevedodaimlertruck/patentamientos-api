using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles.Dtos
{
    public class EventFileCreateOrUpdateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileID { get; set; }

        [Required]
        [StringLength(512)]
        public string Status { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string UserName { get; set; } = string.Empty;
    }
}
