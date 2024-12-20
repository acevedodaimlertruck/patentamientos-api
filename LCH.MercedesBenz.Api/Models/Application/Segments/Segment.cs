using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.Categories;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Segments
{
    [Table("Segments")]
    public class Segment : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [StringLength(3)]
        public string? MercedesCategoriaId { get; set; }

        [StringLength(3)]
        public string? SegName { get; set;}

        [StringLength(20)]
        public string? DescriptionShort { get; set;}

        [StringLength(60)]
        public string? DescriptionLong { get; set;}

        [JsonIgnore]
        public virtual ICollection<InternalVersionSegmentation> InternalVersionSegmentations { get; set; } = new HashSet<InternalVersionSegmentation>();
    }
}
