using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.OFMM;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Terminals;
using LCH.MercedesBenz.Api.Models.Application.TMMVS;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.Brands
{
    [Table("Brands")]
    public class Brand : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [StringLength(256)]
        public string? Description { get; set; }

        [Required]
        public Guid TerminalId { get; set; }

        [JsonIgnore]
        public Terminal? Terminal { get; set; }

        [StringLength(256)]
        public string? MercedesTerminalId { get; set; }

        [StringLength(256)]
        public string? MercedesMarcaId { get; set; }

        //[JsonIgnore]
        //public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();

        //[JsonIgnore]
        //public virtual ICollection<TMMV> TMMVS { get; set; } = new HashSet<TMMV>();

        //[JsonIgnore]
        //public virtual ICollection<Ofmm> Ofmms { get; set; } = new HashSet<Ofmm>();

        //[JsonIgnore]
        //public virtual ICollection<InternalVersion> InternalVersions { get; set; } = new HashSet<InternalVersion>();

        [JsonIgnore]
        public virtual ICollection<CarModel> CarModels { get; set; } = new HashSet<CarModel>();
    }
}
