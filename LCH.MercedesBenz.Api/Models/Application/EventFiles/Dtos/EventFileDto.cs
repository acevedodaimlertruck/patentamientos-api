using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles.Dtos
{
    public class EventFileDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileID { get; set; }
        [JsonIgnore]
        public FileDto? File { get; set; }

        [Required]
        [StringLength(512)]
        public string Status { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string UserName { get; set; } = string.Empty;
    }
}
