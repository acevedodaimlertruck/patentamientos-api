using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesTwo
{
    [Table("AperturesTwo")]
    public class ApertureTwo : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesApertureTwo { get; set; } = string.Empty;
        [StringLength(3)]
        public string? SegCategory { get; set; }

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

        [JsonIgnore]
        public virtual ICollection<OdsOwnerClassification> OdsOwnerClassifications { get; set; } = new HashSet<OdsOwnerClassification>();
    }
}
