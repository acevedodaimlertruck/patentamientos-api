using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.CuitClassifications
{
    [Table("CuitClassifications")]
    public class CuitClassification : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(2)]
        public string MercedesCuitClassification { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

        [JsonIgnore]
        public virtual ICollection<OdsOwnerClassification> OdsOwnerClassifications { get; set; } = new HashSet<OdsOwnerClassification>();
    }
}
