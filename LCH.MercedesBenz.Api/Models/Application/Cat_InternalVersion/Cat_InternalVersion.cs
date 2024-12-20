using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions
{
    [Table("Cat_InternalVersions")]
    public class Cat_InternalVersion : BaseEntity
    {
        public int AutoId { get; set; } = 0;
        [Required]
        public Guid CarModelId { get; set; }
        public CarModel? CarModel { get; set; }
        [StringLength(4)]
        public string? MercedesTerminalId { get; set; }
        [StringLength(4)]
        public string? MercedesMarcaId { get; set; }
        [StringLength(4)]
        public string? MercedesModeloId { get; set; }
        [StringLength(4)]
        public string? Version { get; set; }
        [StringLength(60)]
        public string? Description { get; set; }
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; }

        [JsonIgnore]
        public virtual ICollection<InternalVersionSegmentation> InternalVersionSegmentations { get; set; } = new HashSet<InternalVersionSegmentation>();
    }
}
