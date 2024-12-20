using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Grados.Dtos;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.OdsWholesales.Dtos
{
    public class OdsWholesaleDto : BaseDto
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
        public string CodTrademark { get; set; } = string.Empty;

        [StringLength(128)]
        public string Trademark { get; set; } = string.Empty;

        [Required]
        public Guid GradoId { get; set; }

        public GradoDto? Grado { get; set; }

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

        public VehicleTypeDto? VehicleType { get; set; }

        [StringLength(3)]
        public string Traction { get; set; } = string.Empty;

        [StringLength(2)]
        public string GearsQty { get; set; } = string.Empty;

        [StringLength(2)]
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

        public CategoryDto? Category { get; set; }

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

        public StatePatentaDto? StatePatenta { get; set; }

        [Required]
        public Guid FileId { get; set; }

        public FileDto? File { get; set; }
        public string? ErrorName { get; internal set; }
        public string? Errores { get; internal set; }
    }
}
