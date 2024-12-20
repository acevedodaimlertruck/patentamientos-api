using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.Factories;
using LCH.MercedesBenz.Api.Models.Application.RulePatentings;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Rules
{
    [Table("Rules")]
    public class Rule : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        [Required]
        [StringLength(16)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public Guid RuleTypeId { get; set; }

        [JsonIgnore]
        public virtual RuleType? RuleType { get; set; }

        [JsonIgnore]
        public virtual ICollection<RulePatenting> RulePatentings { get; set; } = new HashSet<RulePatenting>();

    }
}
