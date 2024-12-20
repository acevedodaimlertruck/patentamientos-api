using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Closures.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Departments.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Locations.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Owners.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Provinces.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos
{
    public class PatentingDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid OwnerId { get; set; }

        public OwnerDto? Owner { get; set; }

        [Required]
        public Guid FactoryId { get; set; }

        public FactoryDto? Factory { get; set; }

        [Required]
        public Guid CarModelId { get; set; }

        public CarModelDto? CarModel { get; set; }

        [Required]
        public Guid ClosureId { get; set; }

        public ClosureDto? Closure { get; set; }

        public string Plate { get; set; } = string.Empty;

        public string Motor { get; set; } = string.Empty;

        public string Chasis { get; set; } = string.Empty;

        public string OFMM { get; set; } = string.Empty;

        public string Origen { get; set; } = string.Empty;

        public string FMM_MTM { get; set; } = string.Empty;

        public string CalDay { get; set; } = string.Empty;

        public string CalMonth { get; set; } = string.Empty;

        public string CalYear { get; set; } = string.Empty;

        public string NroRegistro { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string CodigoPostal { get; set; } = string.Empty;

        public string Anio { get; set; } = string.Empty;

        public string Auto { get; set; } = string.Empty;

        public string PaisFabrica { get; set; } = string.Empty;

        public string PaisProced { get; set; } = string.Empty;

        public string Peso { get; set; } = string.Empty;

        [Required]
        public int CantPatentamiento { get; set; } = 1;

        public DateTime? FechaCarga { get; set; }

        public string OFMM_ERROR { get; set; } = string.Empty;

        public bool Es_Duplicado { get; set; } = false;

        [Required]
        public Guid RegSecId { get; set; }

        public RegSecDto? RegSec { get; set; }

        [Required]
        public Guid ProvinceId { get; set; }

        public ProvinceDto? Province { get; set; }

        public Guid DepartmentId { get; set; }

        public DepartmentDto? Department { get; set; }

        [Required]
        public Guid LocationId { get; set; }

        public LocationDto? Location { get; set; }

        //[Required]
        //public Guid BrandId { get; set; }

        //public BrandDto? Brand { get; set; }

        [Required]
        public Guid StatePatentaId { get; set; }

        public StatePatentaDto? StatePatenta { get; set; }

        [Required]
        public Guid VehicleTypeId { get; set; }

        public VehicleTypeDto? VehicleType { get; set; }

        [Required]
        public Guid FileId { get; set; }

        public FileDto? File { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechInsc { get; set; }

        public string FabricaPat { get; set; } = string.Empty;

        public string MarcaPat { get; set; } = string.Empty;

        public string ModeloPat { get; set; } = string.Empty;

        public string? Fabrica_D { get; set; } = string.Empty;

        public string? Marca_D { get; set; } = string.Empty;

        public string? Modelo_D { get; set; } = string.Empty;

        public string? Tipo_D { get; set; } = string.Empty;
        public string ErrorName { get; internal set; }
        public string Errores { get; internal set; }
        public string Texto1OFMM { get; internal set; }
        public string Texto2OFMM { get; internal set; }
        public string TipoTextoOFMM { get; internal set; }
    }
}
