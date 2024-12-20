using LCH.MercedesBenz.Api.Models.Application.Departments;
using LCH.MercedesBenz.Api.Models.Application.Locations;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Provinces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.RegSecs
{
    [Table("RegSecs")]
    public class RegSec : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [StringLength(256)]
        public string? Description { get; set; }

        [StringLength(5)]
        public string? RegistryNumber { get; set; }

        [StringLength(20)]
        public string? RegistryProvince { get; set; }

        [StringLength(30)]
        public string? RegistryDepartment { get; set; }

        [StringLength(30)]
        public string? RegistryLocation { get; set; }

        [StringLength(6)]
        public string? AutoZoneDealer { get; set; }

        [StringLength(60)]
        public string? AutoZoneDescription { get; set; }

        [StringLength(6)]
        public string? TruckZoneDealer { get; set; }

        [StringLength(60)]
        public string? TruckZoneDescription { get; set; }

        [StringLength(6)]
        public string? VanZoneDealer { get; set; }

        [StringLength(60)]
        public string? VanZoneDescription { get; set; }

        //public Guid? ProvinceId { get; set; }
        //public Guid? DepartmentId { get; set; }
        //public Guid? LocationId { get; set; } 

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();
    }
}
