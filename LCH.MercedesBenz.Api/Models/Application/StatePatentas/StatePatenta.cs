using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;

namespace LCH.MercedesBenz.Api.Models.Application.StatePatentas
{
    [Table("StatePatentas")]
    public class StatePatenta : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();

        [JsonIgnore]
        public virtual ICollection<OdsWholesale> OdsWholesales { get; set; } = new HashSet<OdsWholesale>();

    }
}
