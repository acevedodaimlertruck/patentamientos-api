using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.MotorDTs
{
    [Table("MotorDTs")]
    public class MotorDT : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(3)]
        public string MercedesMotorDT { get; set; } = string.Empty;

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? SegCategory { get; set; }

        [JsonIgnore]
        public virtual ICollection<InternalVersionSegmentation> InternalVersionSegmentations { get; set; } = new HashSet<InternalVersionSegmentation>();
    }
}
