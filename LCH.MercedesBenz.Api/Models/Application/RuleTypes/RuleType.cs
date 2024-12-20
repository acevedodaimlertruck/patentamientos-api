using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Rules;

namespace LCH.MercedesBenz.Api.Models.Application.RuleTypes
{
    [Table("RuleTypes")]
    public class RuleType : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Rule> Rules { get; set; } = new HashSet<Rule>();

    }
}
