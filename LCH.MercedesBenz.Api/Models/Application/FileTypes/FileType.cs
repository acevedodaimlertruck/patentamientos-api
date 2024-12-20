using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.FileTypes
{
    [Table("FileTypes")]
    public class FileType : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<File> Files { get; set; } = new HashSet<File>();

    }
}
