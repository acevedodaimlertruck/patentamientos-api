using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;
using Newtonsoft.Json;
using LCH.MercedesBenz.Api.Models.Application.Grados;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes;
using LCH.MercedesBenz.Api.Models.Application.Categories;

namespace LCH.MercedesBenz.Api.Models.Application.OdsWholesales
{
    [Table("OdsWholesales")]
    public class OdsWholesale : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(6)]
        public string YearMonth { get; set; } = string.Empty;

        [Required]
        [StringLength(4)]
        public string CodBrand { get; set; } = string.Empty;

        [StringLength(128)]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [StringLength(5)]
        public string CodModel { get; set; } = string.Empty;

        [StringLength(128)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [StringLength(7)]
        public string CodTrademark { get; set; } = string.Empty; // CODGRADO

        [StringLength(128)]
        public string Trademark { get; set; } = string.Empty; // GRADO

        [Required]
        public Guid GradoId { get; set; }

        [JsonIgnore]
        public virtual Grado? Grado { get; set; }

        [StringLength(1)]
        public string DoorsQty { get; set; } = string.Empty;

        [StringLength(4)]
        public string Engine { get; set; } = string.Empty;

        [StringLength(1)]
        public string MotorType { get; set; } = string.Empty;

        [StringLength(1)]
        public string FuelType { get; set; } = string.Empty;

        [StringLength(5)]
        public string Power { get; set; } = string.Empty;

        [StringLength(3)]
        public string PowerUnit { get; set; } = string.Empty;

        [StringLength(2)]
        public string MercedesVehicleType { get; set; } = string.Empty;

        [Required]
        public Guid VehicleTypeId { get; set; }

        [JsonIgnore]
        public virtual VehicleType? VehicleType { get; set; }

        [StringLength(3)]
        public string Traction { get; set; } = string.Empty;

        [StringLength(2)]
        public string GearsQty { get; set; } = string.Empty;

        [StringLength(1)]
        public string TransmissionType { get; set; } = string.Empty;

        [StringLength(1)]
        public string AxleQty { get; set; } = string.Empty;

        [StringLength(5)]
        public string Weight { get; set; } = string.Empty;

        [StringLength(6)]
        public string LoadCapacity { get; set; } = string.Empty;

        [StringLength(2)]
        public string MercedesCategory { get; set; } = string.Empty;

        [Required]
        public Guid CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category? Category { get; set; }

        [StringLength(2)]
        public string Origin { get; set; } = string.Empty;

        [StringLength(10)]
        public string InitialStock { get; set; } = string.Empty;

        [StringLength(10)]
        public string Import_ProdMonth { get; set; } = string.Empty;

        [StringLength(10)]
        public string Import_ProdAccum { get; set; } = string.Empty;

        [StringLength(10)]
        public string MonthlySale { get; set; } = string.Empty;

        [StringLength(10)]
        public string MonthlyAccum { get; set; } = string.Empty;

        [StringLength(10)]
        public string ExportMonthly { get; set; } = string.Empty;

        [StringLength(10)]
        public string ExportAccum { get; set; } = string.Empty;

        [StringLength(10)]
        public string SavingSystemMonthly { get; set; } = string.Empty;

        [StringLength(10)]
        public string SavingSystemAccum { get; set; } = string.Empty;

        [StringLength(10)]
        public string FinalStock { get; set; } = string.Empty;

        [StringLength(10)]
        public string NoOkStock { get; set; } = string.Empty;

        [Required]
        public Guid StatePatentaId { get; set; }

        [JsonIgnore]
        public virtual StatePatenta? StatePatenta { get; set; }

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public virtual File? File { get; set; }
    }
}
