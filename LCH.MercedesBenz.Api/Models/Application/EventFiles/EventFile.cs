using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles
{
    [Table("EventFiles")]
    public class EventFile : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileID { get; set; }

        public File? File { get; set; }

        [Required]
        [StringLength(128)]
        public string Status { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string UserName { get; set; } = string.Empty;

    }
}
