using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos
{
    public class PatentingUpdateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FactoryId { get; set; }

        [Required]
        public Guid CarModelId { get; set; }

        public string Plate { get; set; } = string.Empty;

        public string Motor { get; set; } = string.Empty;

        public string Chasis { get; set; } = string.Empty;

        public string OFMM { get; set; } = string.Empty;

        //[Required]
        //public Guid BrandId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechInsc { get; set; }

        [Required]
        public Guid VehicleTypeId { get; set; }
    }
}
