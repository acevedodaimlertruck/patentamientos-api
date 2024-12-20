using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos
{
    public class RegSecDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? RegistryNumber { get; set; }

        public string? RegistryProvince { get; set; }

        public string? RegistryDepartment { get; set; }

        public string? RegistryLocation { get; set; }

        public string? AutoZoneDealer { get; set; }

        public string? AutoZoneDescription { get; set; }

        public string? TruckZoneDealer { get; set; }

        public string? TruckZoneDescription { get; set; }

        public string? VanZoneDealer { get; set; }

        public string? VanZoneDescription { get; set; }

        //public Guid? ProvinceId { get; set; }
        //public Guid? DepartmentId { get; set; }
        //public Guid? LocationId { get; set; }

    }
}
