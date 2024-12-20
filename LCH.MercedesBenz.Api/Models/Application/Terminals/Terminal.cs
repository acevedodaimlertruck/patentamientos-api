using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.TMMVS;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.Terminals
{
    [Table("Terminals")]
    public class Terminal : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [StringLength(256)]
        public string? Description { get; set; }

        [StringLength(256)]
        public string? MercedesTerminalId { get; set; }

        //[JsonIgnore]
        //public virtual ICollection<TMMV> TMMVS { get; set; } = new HashSet<TMMV>();

        //[JsonIgnore]
        //public virtual ICollection<InternalVersion> InternalVersions { get; set; } = new HashSet<InternalVersion>();
        
        [JsonIgnore]
        public virtual ICollection<Brand> Brands { get; set; } = new HashSet<Brand>();
    }
}
