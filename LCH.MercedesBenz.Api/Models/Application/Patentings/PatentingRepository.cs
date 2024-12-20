using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Owners.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Closures.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Provinces.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Departments.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Locations.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings
{
    public class PatentingRepository : BaseRepository<Patenting>, IPatentingRepository
    {
        private readonly IMapper _mapper;
        private readonly ISegmentationPlateRepository _segmentationPlateRepository;
        public PatentingRepository(
            IMapper mapper,
            ISegmentationPlateRepository segmentationPlateRepository,
            ApplicationDbContext context) : base(context) 
        {
            _mapper = mapper;
            _segmentationPlateRepository = segmentationPlateRepository;
        }

        public BaseResponse<PatentingDto> GetAll2()
        {
            try
            {
                var results = Context.Patentings.Select(i => new PatentingDto
                {
                    Id = i.Id,
                    OwnerId = i.OwnerId,
                    Owner = i.Owner == null ? null : new OwnerDto
                    {
                        Id = i.Owner.Id,
                        FullName = i.Owner.FullName,
                        CUIT = i.Owner.CUIT,
                        CuitPref = i.Owner.CuitPref
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    },
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    ClosureId = i.ClosureId,
                    Closure = i.Closure == null ? null : new ClosureDto
                    {
                        Id = i.Closure.Id,
                        FechaCorte = i.Closure.FechaCorte,
                        FechaCreacion = i.Closure.FechaCreacion,
                        HoraCreacion = i.Closure.HoraCreacion,
                        EsUltimo = i.Closure.EsUltimo
                    },
                    Plate = i.Plate,
                    Motor = i.Motor,
                    Chasis = i.Chasis,
                    OFMM = i.OFMM,
                    Origen = i.Origen,
                    FMM_MTM = i.FMM_MTM,
                    CalDay = i.CalDay,
                    CalMonth = i.CalMonth,
                    CalYear = i.CalYear,
                    NroRegistro = i.NroRegistro,
                    Direccion = i.Direccion,
                    CodigoPostal = i.CodigoPostal,
                    Anio = i.Anio,
                    Auto = i.Auto,
                    PaisFabrica = i.PaisFabrica,
                    PaisProced = i.PaisProced,
                    Peso = i.Peso,
                    CantPatentamiento = i.CantPatentamiento,
                    FechaCarga = i.FechaCarga,
                    OFMM_ERROR = i.OFMM_ERROR,
                    Es_Duplicado = i.Es_Duplicado,
                    RegSecId = i.RegSecId,
                    RegSec = i.RegSec == null ? null : new RegSecDto
                    {
                        Id = i.RegSec.Id,
                        Name = i.RegSec.Name,
                        Description = i.RegSec.Description,
                        RegistryNumber = i.RegSec.RegistryNumber,
                        RegistryProvince = i.RegSec.RegistryProvince,
                        RegistryDepartment = i.RegSec.RegistryDepartment,
                        RegistryLocation = i.RegSec.RegistryLocation,
                        AutoZoneDealer = i.RegSec.AutoZoneDealer,
                        TruckZoneDealer = i.RegSec.TruckZoneDealer,
                        VanZoneDealer = i.RegSec.VanZoneDealer
                    },
                    ProvinceId = i.ProvinceId,
                    Province = i.Province == null ? null : new ProvinceDto
                    {
                        Id = i.Province.Id,
                        Name = i.Province.Name,
                        Description = i.Province.Description,
                        MercedesProvinciaId = i.Province.MercedesProvinciaId
                    },
                    DepartmentId = i.DepartmentId,
                    Department = i.Department == null ? null : new DepartmentDto
                    {
                        Id = i.Department.Id,
                        Name = i.Department.Name,
                        Description = i.Department.Description,
                        MercedesProvinciaId = i.Department.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Department.MercedesDepartamentoId
                    },
                    LocationId = i.LocationId,
                    Location = i.Location == null ? null : new LocationDto
                    {
                        Id = i.Location.Id,
                        Name = i.Location.Name,
                        Description = i.Location.Description,
                        MercedesProvinciaId = i.Location.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Location.MercedesDepartamentoId,
                        MercedesLocalidadId = i.Location.MercedesLocalidadId
                    },
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description,
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new Files.Dtos.FileDto
                    { 
                        Id = i.FileId, 
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    FechInsc = i.FechInsc,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    ModeloPat = i.ModeloPat,
                    Fabrica_D = i.Fabrica_D,
                    Marca_D = i.Marca_D,
                    Modelo_D = i.Modelo_D,
                    Tipo_D = i.Tipo_D
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<PatentingDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PatentingDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public BaseResponse<dynamic> GetPatentingByFileId(Guid fileId)
        {
            try
            {
                //var result = (from p in Context.Patentings
                //              join o in Context.Owners on p.OwnerId equals o.Id
                //              join f in Context.Factories on p.FactoryId equals f.Id
                //              join cm in Context.CarModels on p.CarModelId equals cm.Id
                //              join b in Context.Brands on cm.BrandId equals b.Id
                //              join sp in Context.StatePatentas on p.StatePatentaId equals sp.Id
                //              join c in Context.Closures on p.ClosureId equals c.Id
                //              from of in Context.Ofmms.Where(of => p.OFMM == of.ZOFMM).DefaultIfEmpty()  // left join
                //              where p.FileId == fileId
                //              select new
                //              {
                //                  IdPatenta = p.Id,
                //                  CUIT = o.CUIT,
                //                  Fabrica = f.Name,
                //                  Marca = b.Name,
                //                  Modelo = cm.Name,
                //                  Patente = p.Plate,
                //                  Motor = p.Motor,
                //                  Chasis = p.Chasis,
                //                  OFMM = p.OFMM,
                //                  FMMTMM = p.FMM_MTM,
                //                  Origen = p.Origen,
                //                  PeriodoDeCorte = c.FechaCorte,
                //                  FechaRegistro = p.FechInsc,
                //                  Texto1OFMM = of.Descripcion1,
                //                  Texto2OFMM = of.Descripcion2,
                //                  Estado = sp.Name,
                //                  ErrorName = string.Join(", ", Context.RulePatentings
                //                     .Where(rp => rp.PatentingId == p.Id)
                //                     .Select(rp => rp.Rule!.Name)),
                //                  Errores = string.Join(", ", Context.RulePatentings
                //                     .Where(rp => rp.PatentingId == p.Id)
                //                     .Select(rp => rp.Rule!.Code))
                //              });
                //var results = result.ToList().Distinct();
                var results = Context.Patentings.Where(s => s.FileId.Equals(fileId)).Select(i => new PatentingDto
                {
                    Id = i.Id,
                    OwnerId = i.OwnerId,
                    Owner = i.Owner == null ? null : new OwnerDto
                    {
                        Id = i.Owner.Id,
                        FullName = i.Owner.FullName,
                        CUIT = i.Owner.CUIT,
                        CuitPref = i.Owner.CuitPref
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    },
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name,
                                Description = i.CarModel.Brand.Terminal.Description,
                                MercedesTerminalId = i.CarModel.Brand.Terminal.MercedesTerminalId
                            }
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    ClosureId = i.ClosureId,
                    Closure = i.Closure == null ? null : new ClosureDto
                    {
                        Id = i.Closure.Id,
                        FechaCorte = i.Closure.FechaCorte,
                        FechaCreacion = i.Closure.FechaCreacion,
                        HoraCreacion = i.Closure.HoraCreacion,
                        EsUltimo = i.Closure.EsUltimo
                    },
                    Plate = i.Plate,
                    Motor = i.Motor,
                    Chasis = i.Chasis,
                    OFMM = i.OFMM,
                    Texto1OFMM = (from o in Context.Ofmms
                                 where (o.ZOFMM == i.OFMM)
                                 select o.Descripcion1).FirstOrDefault()!,
                    Texto2OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion2).FirstOrDefault()!,
                    TipoTextoOFMM = (from o in Context.Ofmms
                                     where (o.ZOFMM == i.OFMM)
                                     select o.TipoDeTexto).FirstOrDefault()!,
                    Origen = i.Origen,
                    FMM_MTM = i.FMM_MTM,
                    CalDay = i.CalDay,
                    CalMonth = i.CalMonth,
                    CalYear = i.CalYear,
                    NroRegistro = i.NroRegistro,
                    Direccion = i.Direccion,
                    CodigoPostal = i.CodigoPostal,
                    Anio = i.Anio,
                    Auto = i.Auto,
                    PaisFabrica = i.PaisFabrica,
                    PaisProced = i.PaisProced,
                    Peso = i.Peso,
                    CantPatentamiento = i.CantPatentamiento,
                    FechaCarga = i.FechaCarga,
                    OFMM_ERROR = i.OFMM_ERROR,
                    Es_Duplicado = i.Es_Duplicado,
                    RegSecId = i.RegSecId,
                    RegSec = i.RegSec == null ? null : new RegSecDto
                    {
                        Id = i.RegSec.Id,
                        Name = i.RegSec.Name,
                        Description = i.RegSec.Description,
                        RegistryNumber = i.RegSec.RegistryNumber,
                        RegistryProvince = i.RegSec.RegistryProvince,
                        RegistryDepartment = i.RegSec.RegistryDepartment,
                        RegistryLocation = i.RegSec.RegistryLocation,
                        AutoZoneDealer = i.RegSec.AutoZoneDealer,
                        TruckZoneDealer = i.RegSec.TruckZoneDealer,
                        VanZoneDealer = i.RegSec.VanZoneDealer
                    },
                    ProvinceId = i.ProvinceId,
                    Province = i.Province == null ? null : new ProvinceDto
                    {
                        Id = i.Province.Id,
                        Name = i.Province.Name,
                        Description = i.Province.Description,
                        MercedesProvinciaId = i.Province.MercedesProvinciaId
                    },
                    DepartmentId = i.DepartmentId,
                    Department = i.Department == null ? null : new DepartmentDto
                    {
                        Id = i.Department.Id,
                        Name = i.Department.Name,
                        Description = i.Department.Description,
                        MercedesProvinciaId = i.Department.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Department.MercedesDepartamentoId
                    },
                    LocationId = i.LocationId,
                    Location = i.Location == null ? null : new LocationDto
                    {
                        Id = i.Location.Id,
                        Name = i.Location.Name,
                        Description = i.Location.Description,
                        MercedesProvinciaId = i.Location.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Location.MercedesDepartamentoId,
                        MercedesLocalidadId = i.Location.MercedesLocalidadId
                    },
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    ErrorName = string.Join(", ", Context.RulePatentings
                                         .Where(rp => rp.PatentingId == i.Id)
                                         .Select(rp => rp.Rule!.Name)),
                    Errores = string.Join(", ", Context.RulePatentings
                                         .Where(rp => rp.PatentingId == i.Id)
                                         .Select(rp => rp.Rule!.Code)),
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description,
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new Files.Dtos.FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    FechInsc = i.FechInsc,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    ModeloPat = i.ModeloPat,
                    Fabrica_D = i.Fabrica_D,
                    Marca_D = i.Marca_D,
                    Modelo_D = i.Modelo_D,
                    Tipo_D = i.Tipo_D
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> GetAllPatentings()
        {
            try
            {
                //var result = (from p in Context.Patentings
                //              join o in Context.Owners on p.OwnerId equals o.Id
                //              join f in Context.Factories on p.FactoryId equals f.Id
                //              join cm in Context.CarModels on p.CarModelId equals cm.Id
                //              join b in Context.Brands on cm.BrandId equals b.Id
                //              join sp in Context.StatePatentas on p.StatePatentaId equals sp.Id
                //              join c in Context.Closures on p.ClosureId equals c.Id
                //              from of in Context.Ofmms.Where(of => p.OFMM == of.ZOFMM).DefaultIfEmpty()  // left join
                //              where sp.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000002"))
                //              select new
                //              {
                //                  IdPatenta = p.Id,
                //                  CUIT = o.CUIT,
                //                  Fabrica = f.Name,
                //                  Marca = b.Name,
                //                  Modelo = cm.Name,
                //                  Patente = p.Plate,
                //                  Motor = p.Motor,
                //                  Chasis = p.Chasis,
                //                  OFMM = p.OFMM,
                //                  FMMTMM = p.FMM_MTM,
                //                  Origen = p.Origen,
                //                  PeriodoDeCorte = c.FechaCorte,
                //                  FechaRegistro = p.FechInsc,
                //                  Texto1OFMM = of.Descripcion1,
                //                  Texto2OFMM = of.Descripcion2,
                //                  Estado = sp.Name,
                //                  ErrorName = string.Join(", ", Context.RulePatentings
                //                     .Where(rp => rp.PatentingId == p.Id)
                //                     .Select(rp => rp.Rule!.Name)),
                //                  Errores = string.Join(", ", Context.RulePatentings
                //                     .Where(rp => rp.PatentingId == p.Id)
                //                     .Select(rp => rp.Rule!.Code))
                //              });
                //var results = result.ToList().Distinct();
                var results = Context.Patentings.Where(s => s.StatePatenta!.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000002"))).Select(i => new PatentingDto
                {
                    Id = i.Id,
                    OwnerId = i.OwnerId,
                    Owner = i.Owner == null ? null : new OwnerDto
                    {
                        Id = i.Owner.Id,
                        FullName = i.Owner.FullName,
                        CUIT = i.Owner.CUIT,
                        CuitPref = i.Owner.CuitPref
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    },
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name,
                                Description = i.CarModel.Brand.Terminal.Description,
                                MercedesTerminalId = i.CarModel.Brand.Terminal.MercedesTerminalId
                            }
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    ClosureId = i.ClosureId,
                    Closure = i.Closure == null ? null : new ClosureDto
                    {
                        Id = i.Closure.Id,
                        FechaCorte = i.Closure.FechaCorte,
                        FechaCreacion = i.Closure.FechaCreacion,
                        HoraCreacion = i.Closure.HoraCreacion,
                        EsUltimo = i.Closure.EsUltimo
                    },
                    Plate = i.Plate,
                    Motor = i.Motor,
                    Chasis = i.Chasis,
                    OFMM = i.OFMM,
                    Texto1OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion1).FirstOrDefault()!,
                    Texto2OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion2).FirstOrDefault()!,
                    TipoTextoOFMM = (from o in Context.Ofmms
                                     where (o.ZOFMM == i.OFMM)
                                     select o.TipoDeTexto).FirstOrDefault()!,
                    Origen = i.Origen,
                    FMM_MTM = i.FMM_MTM,
                    CalDay = i.CalDay,
                    CalMonth = i.CalMonth,
                    CalYear = i.CalYear,
                    NroRegistro = i.NroRegistro,
                    Direccion = i.Direccion,
                    CodigoPostal = i.CodigoPostal,
                    Anio = i.Anio,
                    Auto = i.Auto,
                    PaisFabrica = i.PaisFabrica,
                    PaisProced = i.PaisProced,
                    Peso = i.Peso,
                    CantPatentamiento = i.CantPatentamiento,
                    FechaCarga = i.FechaCarga,
                    OFMM_ERROR = i.OFMM_ERROR,
                    Es_Duplicado = i.Es_Duplicado,
                    RegSecId = i.RegSecId,
                    RegSec = i.RegSec == null ? null : new RegSecDto
                    {
                        Id = i.RegSec.Id,
                        Name = i.RegSec.Name,
                        Description = i.RegSec.Description,
                        RegistryNumber = i.RegSec.RegistryNumber,
                        RegistryProvince = i.RegSec.RegistryProvince,
                        RegistryDepartment = i.RegSec.RegistryDepartment,
                        RegistryLocation = i.RegSec.RegistryLocation,
                        AutoZoneDealer = i.RegSec.AutoZoneDealer,
                        TruckZoneDealer = i.RegSec.TruckZoneDealer,
                        VanZoneDealer = i.RegSec.VanZoneDealer
                    },
                    ProvinceId = i.ProvinceId,
                    Province = i.Province == null ? null : new ProvinceDto
                    {
                        Id = i.Province.Id,
                        Name = i.Province.Name,
                        Description = i.Province.Description,
                        MercedesProvinciaId = i.Province.MercedesProvinciaId
                    },
                    DepartmentId = i.DepartmentId,
                    Department = i.Department == null ? null : new DepartmentDto
                    {
                        Id = i.Department.Id,
                        Name = i.Department.Name,
                        Description = i.Department.Description,
                        MercedesProvinciaId = i.Department.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Department.MercedesDepartamentoId
                    },
                    LocationId = i.LocationId,
                    Location = i.Location == null ? null : new LocationDto
                    {
                        Id = i.Location.Id,
                        Name = i.Location.Name,
                        Description = i.Location.Description,
                        MercedesProvinciaId = i.Location.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Location.MercedesDepartamentoId,
                        MercedesLocalidadId = i.Location.MercedesLocalidadId
                    },
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    ErrorName = string.Join(", ", Context.RulePatentings
                                        .Where(rp => rp.PatentingId == i.Id)
                                        .Select(rp => rp.Rule!.Name)),
                    Errores = string.Join(", ", Context.RulePatentings
                                        .Where(rp => rp.PatentingId == i.Id)
                                        .Select(rp => rp.Rule!.Code)),
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description,
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new Files.Dtos.FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    FechInsc = i.FechInsc,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    ModeloPat = i.ModeloPat,
                    Fabrica_D = i.Fabrica_D,
                    Marca_D = i.Marca_D,
                    Modelo_D = i.Modelo_D,
                    Tipo_D = i.Tipo_D
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<PatentingDto> GetPatentingsFiltered(string? dateFrom, string? dateTo, bool? lastDischarge, string? errorType, string? fileId)
        {
            try
            {
                var results = Context.Patentings.Where(s => s.StatePatenta!.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000002"))).Select(i => new PatentingDto
                {
                    Id = i.Id,
                    OwnerId = i.OwnerId,
                    Owner = i.Owner == null ? null : new OwnerDto
                    {
                        Id = i.Owner.Id,
                        FullName = i.Owner.FullName,
                        CUIT = i.Owner.CUIT,
                        CuitPref = i.Owner.CuitPref
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    },
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name,
                                Description = i.CarModel.Brand.Terminal.Description,
                                MercedesTerminalId = i.CarModel.Brand.Terminal.MercedesTerminalId
                            }
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    ClosureId = i.ClosureId,
                    Closure = i.Closure == null ? null : new ClosureDto
                    {
                        Id = i.Closure.Id,
                        FechaCorte = i.Closure.FechaCorte,
                        FechaCreacion = i.Closure.FechaCreacion,
                        HoraCreacion = i.Closure.HoraCreacion,
                        EsUltimo = i.Closure.EsUltimo
                    },
                    Plate = i.Plate,
                    Motor = i.Motor,
                    Chasis = i.Chasis,
                    OFMM = i.OFMM,
                    Texto1OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion1).FirstOrDefault()!,
                    Texto2OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion2).FirstOrDefault()!,
                    TipoTextoOFMM = (from o in Context.Ofmms
                                     where (o.ZOFMM == i.OFMM)
                                     select o.TipoDeTexto).FirstOrDefault()!,
                    Origen = i.Origen,
                    FMM_MTM = i.FMM_MTM,
                    CalDay = i.CalDay,
                    CalMonth = i.CalMonth,
                    CalYear = i.CalYear,
                    NroRegistro = i.NroRegistro,
                    Direccion = i.Direccion,
                    CodigoPostal = i.CodigoPostal,
                    Anio = i.Anio,
                    Auto = i.Auto,
                    PaisFabrica = i.PaisFabrica,
                    PaisProced = i.PaisProced,
                    Peso = i.Peso,
                    CantPatentamiento = i.CantPatentamiento,
                    FechaCarga = i.FechaCarga,
                    OFMM_ERROR = i.OFMM_ERROR,
                    Es_Duplicado = i.Es_Duplicado,
                    RegSecId = i.RegSecId,
                    RegSec = i.RegSec == null ? null : new RegSecDto
                    {
                        Id = i.RegSec.Id,
                        Name = i.RegSec.Name,
                        Description = i.RegSec.Description,
                        RegistryNumber = i.RegSec.RegistryNumber,
                        RegistryProvince = i.RegSec.RegistryProvince,
                        RegistryDepartment = i.RegSec.RegistryDepartment,
                        RegistryLocation = i.RegSec.RegistryLocation,
                        AutoZoneDealer = i.RegSec.AutoZoneDealer,
                        TruckZoneDealer = i.RegSec.TruckZoneDealer,
                        VanZoneDealer = i.RegSec.VanZoneDealer
                    },
                    ProvinceId = i.ProvinceId,
                    Province = i.Province == null ? null : new ProvinceDto
                    {
                        Id = i.Province.Id,
                        Name = i.Province.Name,
                        Description = i.Province.Description,
                        MercedesProvinciaId = i.Province.MercedesProvinciaId
                    },
                    DepartmentId = i.DepartmentId,
                    Department = i.Department == null ? null : new DepartmentDto
                    {
                        Id = i.Department.Id,
                        Name = i.Department.Name,
                        Description = i.Department.Description,
                        MercedesProvinciaId = i.Department.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Department.MercedesDepartamentoId
                    },
                    LocationId = i.LocationId,
                    Location = i.Location == null ? null : new LocationDto
                    {
                        Id = i.Location.Id,
                        Name = i.Location.Name,
                        Description = i.Location.Description,
                        MercedesProvinciaId = i.Location.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Location.MercedesDepartamentoId,
                        MercedesLocalidadId = i.Location.MercedesLocalidadId
                    },
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    ErrorName = string.Join(", ", Context.RulePatentings
                                        .Where(rp => rp.PatentingId == i.Id)
                                        .Select(rp => rp.Rule!.Name)),
                    Errores = string.Join(", ", Context.RulePatentings
                                        .Where(rp => rp.PatentingId == i.Id)
                                        .Select(rp => rp.Rule!.Code)),
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description,
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new Files.Dtos.FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    FechInsc = i.FechInsc,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    ModeloPat = i.ModeloPat,
                    Fabrica_D = i.Fabrica_D,
                    Marca_D = i.Marca_D,
                    Modelo_D = i.Modelo_D,
                    Tipo_D = i.Tipo_D
                }).OrderBy(i => i.Id).ToList();

                if (lastDischarge == true)
                {
                    var lastFileId = Context.Files.Where(f => f.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000010")) || f.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000030")))
                    .OrderByDescending(fp => fp.CreatedAt)
                    .FirstOrDefault();
                    results = results.Where(s => s.FileId.Equals(lastFileId!.Id)).ToList();
                }
                if (fileId != null)
                {
                    results = results.Where(s => s.FileId.Equals(Guid.Parse(fileId))).ToList();
                }
                if (dateFrom != null || dateTo != null)
                {
                    DateTime parsedDateFrom = new DateTime(1000, 01, 01);
                    DateTime parsedDateTo = DateTime.Now;
                    if (dateFrom != null) parsedDateFrom = DateTime.Parse(dateFrom!);
                    if (dateTo != null) parsedDateTo = DateTime.Parse(dateTo!);                    
                    results = results.Where(s => s.FechInsc >= parsedDateFrom && s.FechInsc <= parsedDateTo).ToList();
                }
                if (errorType != null)
                {
                    if (errorType != "all")
                        results = results.Where(s => s.Errores.Contains(errorType)).ToList();
                }
                return new BaseResponse<PatentingDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PatentingDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> GetRulesPatentingById(Guid patentingId)
        {
            try
            {
                var result = from rp in Context.RulePatentings
                             join r in Context.Rules on rp.RuleId equals r.Id
                             where rp.PatentingId == patentingId && rp.IsDeleted == false
                             select new
                             {
                                 Id = r.Id,
                                 Regla = r.Name,
                                 Codigo = r.Code
                             };
                var results = result.ToList();
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> ProcessByFileId(Guid fileId, Guid fileTypeId, Guid? wsID)
        {
            try
            {
                var param = new SqlParameter { ParameterName = "FileId", Value = fileId };
                var wsParam = new SqlParameter { ParameterName = "wsID", Value = wsID };
                wsParam.Value = wsParam.Value ?? DBNull.Value;
                if (fileTypeId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000010")))
                {
                    var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_cargaPatenta] @FileId", param);
                    var process = _segmentationPlateRepository.ProcessSegmentations(null, null, fileId, null);
                    return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
                }
                else if (fileTypeId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000030")))
                {
                    var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_cargaPatentaMensual] @FileId", param);
                    var process = _segmentationPlateRepository.ProcessSegmentations(null, null, fileId, null);
                    return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
                }
                else if (fileTypeId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000020")))
                {
                    var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_cargaWholesale] @FileId, @wsID", param, wsParam);
                    return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
                }
                else if (fileTypeId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000040")))
                {
                    var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_cargaSpercialSales] @FileId", param);
                    return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
                }
                else if (fileTypeId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000050")))
                {
                    var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_cargaPatentaHist] @FileId", param);
                    Context.Database.SetCommandTimeout(0);
                    return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
                }
                    return new BaseResponse<dynamic>(StatusCodes.Status400BadRequest, $"Tipo de archivo inválido.");
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> SaveByPatentingId(Guid patentingId)
        {
            try
            {
                var param = new SqlParameter { ParameterName = "PatId", Value = patentingId };
                var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_executeRuleByPatenta] @PatId", param);
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public BaseResponse<PatentingDto> GetPatentingById(Guid patentingId)
        {
            try
            {
                var results = Context.Patentings.Where(s => s.Id.Equals(patentingId)).Select(i => new PatentingDto
                {
                    Id = i.Id,
                    OwnerId = i.OwnerId,
                    Owner = i.Owner == null ? null : new OwnerDto
                    {
                        Id = i.Owner.Id,
                        FullName = i.Owner.FullName,
                        CUIT = i.Owner.CUIT,
                        CuitPref = i.Owner.CuitPref
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    },
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    ClosureId = i.ClosureId,
                    Closure = i.Closure == null ? null : new ClosureDto
                    {
                        Id = i.Closure.Id,
                        FechaCorte = i.Closure.FechaCorte,
                        FechaCreacion = i.Closure.FechaCreacion,
                        HoraCreacion = i.Closure.HoraCreacion,
                        EsUltimo = i.Closure.EsUltimo
                    },
                    Plate = i.Plate,
                    Motor = i.Motor,
                    Chasis = i.Chasis,
                    OFMM = i.OFMM,
                    Origen = i.Origen,
                    FMM_MTM = i.FMM_MTM,
                    CalDay = i.CalDay,
                    CalMonth = i.CalMonth,
                    CalYear = i.CalYear,
                    NroRegistro = i.NroRegistro,
                    Direccion = i.Direccion,
                    CodigoPostal = i.CodigoPostal,
                    Anio = i.Anio,
                    Auto = i.Auto,
                    PaisFabrica = i.PaisFabrica,
                    PaisProced = i.PaisProced,
                    Peso = i.Peso,
                    CantPatentamiento = i.CantPatentamiento,
                    FechaCarga = i.FechaCarga,
                    OFMM_ERROR = i.OFMM_ERROR,
                    Es_Duplicado = i.Es_Duplicado,
                    RegSecId = i.RegSecId,
                    RegSec = i.RegSec == null ? null : new RegSecDto
                    {
                        Id = i.RegSec.Id,
                        Name = i.RegSec.Name,
                        Description = i.RegSec.Description,
                        RegistryNumber = i.RegSec.RegistryNumber,
                        RegistryProvince = i.RegSec.RegistryProvince,
                        RegistryDepartment = i.RegSec.RegistryDepartment,
                        RegistryLocation = i.RegSec.RegistryLocation,
                        AutoZoneDealer = i.RegSec.AutoZoneDealer,
                        TruckZoneDealer = i.RegSec.TruckZoneDealer,
                        VanZoneDealer = i.RegSec.VanZoneDealer
                    },
                    ProvinceId = i.ProvinceId,
                    Province = i.Province == null ? null : new ProvinceDto
                    {
                        Id = i.Province.Id,
                        Name = i.Province.Name,
                        Description = i.Province.Description,
                        MercedesProvinciaId = i.Province.MercedesProvinciaId
                    },
                    DepartmentId = i.DepartmentId,
                    Department = i.Department == null ? null : new DepartmentDto
                    {
                        Id = i.Department.Id,
                        Name = i.Department.Name,
                        Description = i.Department.Description,
                        MercedesProvinciaId = i.Department.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Department.MercedesDepartamentoId
                    },
                    LocationId = i.LocationId,
                    Location = i.Location == null ? null : new LocationDto
                    {
                        Id = i.Location.Id,
                        Name = i.Location.Name,
                        Description = i.Location.Description,
                        MercedesProvinciaId = i.Location.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Location.MercedesDepartamentoId,
                        MercedesLocalidadId = i.Location.MercedesLocalidadId
                    },
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description,
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new Files.Dtos.FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    FechInsc = i.FechInsc,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    ModeloPat = i.ModeloPat,
                    Fabrica_D = i.Fabrica_D,
                    Marca_D = i.Marca_D,
                    Modelo_D = i.Modelo_D,
                    Tipo_D = i.Tipo_D
                }).OrderBy(i => i.Id).FirstOrDefault();
                return new BaseResponse<PatentingDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PatentingDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Patenting> SavePatenting(PatentingUpdateDto patentingDto)
        {
            try
            {
                if(patentingDto.Id == Guid.Empty)
                    return new BaseResponse<Patenting>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Patentings.SingleOrDefault(p => p.Id.Equals(patentingDto.Id));
                if (entity == null)
                    return new BaseResponse<Patenting>(StatusCodes.Status400BadRequest, $"Patenting no encontrado (Id={patentingDto.Id}).");
                _mapper.Map(patentingDto, entity);
                entity.OFMM = patentingDto.OFMM;
                entity.Plate = patentingDto.Plate;
                entity.Chasis = patentingDto.Chasis;
                entity.Motor = patentingDto.Motor;
                entity.VehicleTypeId= patentingDto.VehicleTypeId;
                entity.FechInsc = patentingDto.FechInsc;
                entity.CarModelId = patentingDto.CarModelId;
                entity.FactoryId = patentingDto.FactoryId;
                UpdateAndSave(entity);
                var param = new SqlParameter { ParameterName = "PatId", Value = entity.Id };
                var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_executeRuleByPatenta] @PatId", param);
                var process = _segmentationPlateRepository.ProcessSegmentations(null, null, null, entity.Id);

                return new BaseResponse<Patenting>(StatusCodes.Status200OK, entity);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Patenting>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> FixErrorOfmm(string ofmm)
        {
            try
            {
                var param = new SqlParameter { ParameterName = "newOFMM", Value = ofmm };
                var result = Context.Database.ExecuteSqlRaw("EXECUTE [dbo].[usp_actualizaErrorOFMM] @newOFMM", param);
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> GetLastFilePatenting()
        {
            try
            {
                var lastFileId = Context.Files.Where(f => f.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000010")) || f.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000030")))
                    .OrderByDescending(fp => fp.CreatedAt)
                    .FirstOrDefault();
                var results = Context.Patentings.Where(s => s.StatePatenta!.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000002")) && s.FileId.Equals(lastFileId!.Id)).Select(i => new PatentingDto
                {
                    Id = i.Id,
                    OwnerId = i.OwnerId,
                    Owner = i.Owner == null ? null : new OwnerDto
                    {
                        Id = i.Owner.Id,
                        FullName = i.Owner.FullName,
                        CUIT = i.Owner.CUIT,
                        CuitPref = i.Owner.CuitPref
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    },
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    ClosureId = i.ClosureId,
                    Closure = i.Closure == null ? null : new ClosureDto
                    {
                        Id = i.Closure.Id,
                        FechaCorte = i.Closure.FechaCorte,
                        FechaCreacion = i.Closure.FechaCreacion,
                        HoraCreacion = i.Closure.HoraCreacion,
                        EsUltimo = i.Closure.EsUltimo
                    },
                    Plate = i.Plate,
                    Motor = i.Motor,
                    Chasis = i.Chasis,
                    OFMM = i.OFMM,
                    Texto1OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion1).FirstOrDefault()!,
                    Texto2OFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.Descripcion2).FirstOrDefault()!,
                    TipoTextoOFMM = (from o in Context.Ofmms
                                  where (o.ZOFMM == i.OFMM)
                                  select o.TipoDeTexto).FirstOrDefault()!,
                    Origen = i.Origen,
                    FMM_MTM = i.FMM_MTM,
                    CalDay = i.CalDay,
                    CalMonth = i.CalMonth,
                    CalYear = i.CalYear,
                    NroRegistro = i.NroRegistro,
                    Direccion = i.Direccion,
                    CodigoPostal = i.CodigoPostal,
                    Anio = i.Anio,
                    Auto = i.Auto,
                    PaisFabrica = i.PaisFabrica,
                    PaisProced = i.PaisProced,
                    Peso = i.Peso,
                    CantPatentamiento = i.CantPatentamiento,
                    FechaCarga = i.FechaCarga,
                    OFMM_ERROR = i.OFMM_ERROR,
                    Es_Duplicado = i.Es_Duplicado,
                    RegSecId = i.RegSecId,
                    RegSec = i.RegSec == null ? null : new RegSecDto
                    {
                        Id = i.RegSec.Id,
                        Name = i.RegSec.Name,
                        Description = i.RegSec.Description,
                        RegistryNumber = i.RegSec.RegistryNumber,
                        RegistryProvince = i.RegSec.RegistryProvince,
                        RegistryDepartment = i.RegSec.RegistryDepartment,
                        RegistryLocation = i.RegSec.RegistryLocation,
                        AutoZoneDealer = i.RegSec.AutoZoneDealer,
                        TruckZoneDealer = i.RegSec.TruckZoneDealer,
                        VanZoneDealer = i.RegSec.VanZoneDealer
                    },
                    ProvinceId = i.ProvinceId,
                    Province = i.Province == null ? null : new ProvinceDto
                    {
                        Id = i.Province.Id,
                        Name = i.Province.Name,
                        Description = i.Province.Description,
                        MercedesProvinciaId = i.Province.MercedesProvinciaId
                    },
                    DepartmentId = i.DepartmentId,
                    Department = i.Department == null ? null : new DepartmentDto
                    {
                        Id = i.Department.Id,
                        Name = i.Department.Name,
                        Description = i.Department.Description,
                        MercedesProvinciaId = i.Department.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Department.MercedesDepartamentoId
                    },
                    LocationId = i.LocationId,
                    Location = i.Location == null ? null : new LocationDto
                    {
                        Id = i.Location.Id,
                        Name = i.Location.Name,
                        Description = i.Location.Description,
                        MercedesProvinciaId = i.Location.MercedesProvinciaId,
                        MercedesDepartamentoId = i.Location.MercedesDepartamentoId,
                        MercedesLocalidadId = i.Location.MercedesLocalidadId
                    },
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    ErrorName = string.Join(", ", Context.RulePatentings
                                    .Where(rp => rp.PatentingId == i.Id)
                                    .Select(rp => rp.Rule!.Name)),
                    Errores = string.Join(", ", Context.RulePatentings
                                    .Where(rp => rp.PatentingId == i.Id)
                                    .Select(rp => rp.Rule!.Code)),
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description,
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new Files.Dtos.FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    FechInsc = i.FechInsc,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    ModeloPat = i.ModeloPat,
                    Fabrica_D = i.Fabrica_D,
                    Marca_D = i.Marca_D,
                    Modelo_D = i.Modelo_D,
                    Tipo_D = i.Tipo_D
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
