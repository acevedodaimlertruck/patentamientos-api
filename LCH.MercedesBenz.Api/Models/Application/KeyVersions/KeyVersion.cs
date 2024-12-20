using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;

namespace LCH.MercedesBenz.Api.Models.Application.KeyVersions
{
    [Table("KeyVersions")]
    public class KeyVersion : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [StringLength(3)]
        public string? MercedesTerminalId { get; set; }

        [StringLength(3)]
        public string? MercedesMarcaId { get; set; }

        [StringLength(3)]
        public string? MercedesModeloId { get; set; }

        [StringLength(4)]
        public string? MercedesVersionClaveId { get; set; }
        
        [StringLength(5)]
        public string? MercedesVersionInternaId { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; }

        [StringLength(60)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

        [StringLength(5)]
        public string? SegCategory { get; set; }

        [StringLength(5)]
        public string? SegName { get; set; }

        [JsonIgnore]
        public virtual ICollection<SegmentationPlate> SegmentationPlates { get; set; } = new HashSet<SegmentationPlate>();
    }
}
