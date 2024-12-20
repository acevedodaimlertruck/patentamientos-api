using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.VehicleTypes
{
    [Table("VehicleTypes")]
    public class VehicleType : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [StringLength(256)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();

        [JsonIgnore]
        public virtual ICollection<OdsWholesale> OdsWholesales { get; set; } = new HashSet<OdsWholesale>();
    }
}
