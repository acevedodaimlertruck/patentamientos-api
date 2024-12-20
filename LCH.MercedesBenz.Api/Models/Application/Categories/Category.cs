using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;

namespace LCH.MercedesBenz.Api.Models.Application.Categories
{
    [Table("Categories")]
    public class Category : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [StringLength(3)]
        public string? SegCategory { get; set; }

        [StringLength(20)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<InternalVersionSegmentation> InternalVersionSegmentations { get; set; } = new HashSet<InternalVersionSegmentation>();

        [JsonIgnore]
        public virtual ICollection<OdsWholesale> OdsWholesales { get; set; } = new HashSet<OdsWholesale>();

    }
}
