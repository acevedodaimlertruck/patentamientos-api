using LCH.MercedesBenz.Api.Models.Application.Patentings;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.Owners
{
    [Table("Owners")]
    public class Owner : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(256)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [StringLength(16)]
        public string CUIT { get; set; } = string.Empty;

        [StringLength(2)]
        public string CuitPref { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();
    }
}
