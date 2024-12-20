using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
using LCH.MercedesBenz.Api.Models.Application.Rules;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.RuleOdsWholesales
{
    [Table("RuleOdsWholesale")]
    public class RuleOdsWholesale : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid RuleId { get; set; }

        [JsonIgnore]
        public virtual Rule? Rule { get; set; }

        [Required]
        public Guid OdsWholesaleId { get; set; }

        [JsonIgnore]
        public virtual OdsWholesale? OdsWholesale { get; set; }

    }
}
