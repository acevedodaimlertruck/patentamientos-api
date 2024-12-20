using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Rules;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.RulePatentings
{
    [Table("RulePatenting")]
    public class RulePatenting : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid RuleId { get; set; }

        [JsonIgnore]
        public virtual Rule? Rule { get; set; }

        [Required]
        public Guid PatentingId { get; set; }

        [JsonIgnore]
        public virtual Patenting? Patenting { get; set; }

    }
}
