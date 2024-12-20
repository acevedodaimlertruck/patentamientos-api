using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using LCH.MercedesBenz.Api.Models.Application.Dailies;
using LCH.MercedesBenz.Api.Models.Application.Dailies.Dtos;
using LCH.MercedesBenz.Api.Models.Application.EventFiles;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Historicals;
using LCH.MercedesBenz.Api.Models.Application.Historicals.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Monthlies;
using LCH.MercedesBenz.Api.Models.Application.Monthlies.Dtos;
using LCH.MercedesBenz.Api.Models.Application.SpecialSales;
using LCH.MercedesBenz.Api.Models.Application.SpecialSales.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Wholesales;
using LCH.MercedesBenz.Api.Models.Application.Wholesales.Dtos;
using LCH.MercedesBenz.Api.Services.Azure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.Files
{
    public class FileRepository : BaseRepository<File>, IFileRepository
    {
        private readonly IEventFileRepository _eventFileRepository;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IDailyRepository _dailyRepository;
        private readonly IMonthlyRepository _monthlyRepository;
        private readonly IWholesaleRepository _wholesaleRepository;
        private readonly ISpecialSaleRepository _specialSaleRepository;
        private readonly IHistoricalRepository _historicalRepository;
        private readonly IConfiguration _configuration;
        private readonly AzureService _azureService;

        public FileRepository(
            ApplicationDbContext context,
            IEventFileRepository eventFileRepository,
            IHttpContextAccessor contextAccessor,
            IDailyRepository dailyRepository,
            IMonthlyRepository monthlyRepository,
            IWholesaleRepository wholesaleRepository,
            ISpecialSaleRepository specialSaleRepository,
            IHistoricalRepository historicalRepository,
            IConfiguration configuration,
            AzureService azureService) : base(context)
        {
            _eventFileRepository = eventFileRepository;
            _contextAccessor = contextAccessor;
            _dailyRepository = dailyRepository;
            _monthlyRepository = monthlyRepository;
            _wholesaleRepository = wholesaleRepository;
            _specialSaleRepository = specialSaleRepository;
            _historicalRepository = historicalRepository;
            _azureService = azureService;
            _configuration = configuration;
        }

        public BaseResponse<FileDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<FileDto>();
                Expression<Func<File, FileDto>> selector = e => new FileDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    Name = e.Name,
                    Status = e.Status,
                    RecordQuantity = e.RecordQuantity,
                    URL = e.URL,
                    Date = e.Date,
                    Day = e.Day,
                    Month = e.Month,
                    Year = e.Year,
                    FileTypeID = e.FileTypeID,
                    FileType = e.FileType == null ? null : new FileTypeDto
                    {
                        Id = e.FileType.Id,
                        Name = e.FileType.Name,
                        Description = e.FileType.Description
                    },
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.Files.Select(selector).ToList();
                    return new BaseResponse<FileDto>(StatusCodes.Status200OK, results);
                }
                Func<FileDto, object> orderBy;
                switch (by)
                {
                    case "AutoId":
                        orderBy = e => e.AutoId;
                        break;
                    case "Name":
                        orderBy = e => e.Name;
                        break;
                    case "UpdatedAt":
                        orderBy = e => e.UpdatedAt;
                        break;
                    default:
                        orderBy = e => e.CreatedAt;
                        break;
                }
                if (direction == Direction.Ascending)
                {
                    results = Context.Files.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<FileDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.Files.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<FileDto>(StatusCodes.Status200OK, results);
                }
                results = Context.Files.Select(selector).ToList();
                return new BaseResponse<FileDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FileDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
        public BaseResponse<FileDto> GetAll2()
        {
            try
            {
                var results = Context.Files.Select(i => new FileDto
                {
                    Id = i.Id,
                    AutoId = i.AutoId,
                    Name = i.Name,
                    Status = i.Status,
                    RecordQuantity = i.RecordQuantity,
                    URL = i.URL,
                    Date = i.Date,
                    Day = i.Day,
                    Month = i.Month,
                    Year = i.Year,
                    FileTypeID = i.FileTypeID,
                    FileType = i.FileType == null ? null : new FileTypeDto
                    {
                        Id = i.FileType.Id,
                        Name = i.FileType.Name,
                        Description = i.FileType.Description
                    },
                    CreatedAt = i.CreatedAt,
                    UpdatedAt = i.UpdatedAt
                }).OrderByDescending(i => i.CreatedAt).ToList();
                return new BaseResponse<FileDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FileDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public async Task<BaseResponse<File>> CreateAsync(FileCreateOrUpdateDto dto)
        {
            try
            {
                var fileResponse = GetSingle(u => u.Id.Equals(dto.Id));
                if (fileResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<File>(StatusCodes.Status400BadRequest, fileResponse.Message, fileResponse.StackTrace);
                var file = fileResponse.Result;
                if (file != null)
                    return new BaseResponse<File>(StatusCodes.Status400BadRequest, $"El archivo ya existe.");

                var fileUpload = dto.FileUpload.Substring(dto.FileUpload.LastIndexOf(',') + 1);
                var bytess = Convert.FromBase64String(fileUpload);
                var upload = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
                if (!Directory.Exists(upload))
                    Directory.CreateDirectory(upload);
                var fullPath = Path.Combine(upload, dto.Name);
                string newFileName;
                string uriFile;
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    newFileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Name);
                    fileStream.Write(bytess, 0, bytess.Length);
                    fileStream.Flush();
                    uriFile = await _azureService.UploadCSVToAzureAsync(fileStream, newFileName);

                }
                var csvTable = ConvertCSVtoDataTable(fullPath);
                var fileName = Path.GetFileName(fullPath);
                var rowCount = csvTable.Rows.Count.ToString();
                file = new File
                {
                    Name = dto.Name,
                    Status = dto.Status,
                    RecordQuantity = rowCount,
                    URL = uriFile,
                    Date = dto.Date,
                    Day = dto.Day,
                    Month = dto.Month,
                    Year = dto.Year,
                    FileTypeID = dto.FileTypeID
                };

                if (string.IsNullOrEmpty(dto.Id.ToString()))
                    file.Id = Guid.NewGuid();
                else
                    file.Id = (Guid)dto.Id;
                InsertAndSave(file);

                var dailies = new List<Daily>();
                var monthlies = new List<Monthly>();
                var wholesales = new List<Wholesale>();
                var specialSales = new List<SpecialSale>();
                var historicals = new List<Historical>();

                if (file.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000010")))
                {
                    foreach (DataRow row in csvTable.Rows)
                    {
                        DateTime dateTime = DateTime.ParseExact(row[9].ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                        var dailyObject = new Daily
                        {
                            Source = (string)row[0],
                            Plate = (string)row[1],
                            Motor = (string)row[2],
                            Chassis = (string)row[3],
                            FMM_MTM = (string)row[4],
                            Factory_D = (string)row[5],
                            Brand_D = (string)row[6],
                            Model_D = (string)row[7],
                            Type_D = (string)row[8],
                            Reg_Date = dateTime,
                            RegSec = (string)row[10],
                            Desc_Reg = (string)row[11],
                            Desc_Prov = (string)row[12],
                            Taxi = (string)row[13],
                            CUIT = (string)row[14],
                        };
                        dailyObject.FileId = file.Id;
                        dailies.Add(dailyObject);
                    }
                    _dailyRepository.BulkInsert(dailies);
                }
                else if (file.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000030")))
                {
                    foreach (DataRow row in csvTable.Rows)
                    {
                        DateTime dateTime = DateTime.ParseExact(row[9].ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                        var monthlyObject = new Monthly
                        {
                            Id = Guid.NewGuid(),
                            Source = (string)row[0],
                            Plate = (string)row[1],
                            Motor = (string)row[2],
                            Chassis = (string)row[3],
                            FMM_MTM = (string)row[4],
                            Factory_D = (string)row[5],
                            Brand_D = (string)row[6],
                            Model_D = (string)row[7],
                            Type_D = (string)row[8],
                            Reg_Date = dateTime,
                            RegSec = (string)row[10],
                            Desc_Reg = (string)row[11],
                            Mode = (string)row[12],
                            Owner = (string)row[13],
                            CUIT_PREF = (string)row[14],
                            Address = (string)row[15],
                            COD_PRO = (string)row[16],
                            DESC_PROV = (string)row[17],
                            COD_DPT = (string)row[18],
                            DESC_DPT = (string)row[19],
                            COD_LOC = (string)row[20],
                            DESC_LOC = (string)row[21],
                            City = (string)row[22],
                            Zip = (string)row[23],
                            Year_Model = (string)row[24],
                            CodCar = (string)row[25],
                            CountryFA = (string)row[26],
                            CountryPR = (string)row[27],
                            Weight = (string)row[28],
                            CUIT = (string)row[29],
                        };
                        monthlyObject.FileId = file.Id;
                        monthlies.Add(monthlyObject);
                    }
                    _monthlyRepository.BulkInsert(monthlies);
                }
                else if (file.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000020")))
                {
                    foreach (DataRow row in csvTable.Rows)
                    {
                        var wholesaleObject = new Wholesale
                        {
                            Id = Guid.NewGuid(),
                            YearMonth = (string)row[0],
                            CodBrand = (string)row[1],
                            Brand = (string)row[2],
                            CodModel = (string)row[3],
                            Model = (string)row[4],
                            CodTrademark = (string)row[5],
                            Trademark = (string)row[6],
                            DoorsQty = (string)row[7],
                            Engine = (string)row[8],
                            MotorType = (string)row[9],
                            FuelType = (string)row[10],
                            Power = (string)row[11],
                            PowerUnit = (string)row[12],
                            VehicleType = (string)row[13],
                            Traction = (string)row[14],
                            GearsQty = (string)row[15],
                            TransmissionType = (string)row[16],
                            AxleQty = (string)row[17],
                            Weight = (string)row[18],
                            LoadCapacity = (string)row[19],
                            Category = (string)row[20],
                            Origin = (string)row[21],
                            InitialStock = (string)row[22],
                            Import_ProdMonth = (string)row[23],
                            Import_ProdAccum = (string)row[24],
                            MonthlySale = (string)row[25],
                            MonthlyAccum = (string)row[26],
                            ExportMonthly = (string)row[27],
                            ExportAccum = (string)row[28],
                            SavingSystemMonthly = (string)row[29],
                            SavingSystemAccum = (string)row[30],
                            FinalStock = (string)row[31],
                            NoOkStock = (string)row[32],
                        };
                        wholesaleObject.FileId = file.Id;
                        wholesales.Add(wholesaleObject);
                    }
                    _wholesaleRepository.BulkInsert(wholesales);
                }
                else if (file.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000040")))
                {
                    foreach (DataRow row in csvTable.Rows)
                    {
                        var specialSaleObject = new SpecialSale
                        {
                            Id = Guid.NewGuid(),
                            CuitOwner = (string)row[0],
                            Owner = (string)row[1],
                            LegalEntity = (string)row[2],
                            DescriptionLegalEntity = (string)row[3],
                            GovernmentalClassification = (string)row[4],
                            DescriptionGovernmentalClassification = (string)row[5],
                            SubgovernmentalClassification = (string)row[6],
                            DescriptionSubgovernmentalClassification = (string)row[7],
                            CuitClassification = (string)row[8],
                            DescriptionCuitClassification = (string)row[9],
                            Aperture1 = (string)row[10],
                            DescriptionAperture1 = (string)row[11],
                            Aperture2 = (string)row[12],
                            DescriptionAperture2 = (string)row[13],
                            LogisticClassification = (string)row[14],
                            DescriptionLogisticClassification = (string)row[15],
                            EstimatedTurnover = (string)row[16],
                            DescriptionEstimatedTurnover = (string)row[17],
                            SocialContractDate = (string)row[18],
                            EmployeesInfo = (string)row[19],
                        };
                        specialSaleObject.FileId = file.Id;
                        specialSales.Add(specialSaleObject);
                    }
                    _specialSaleRepository.BulkInsert(specialSales);
                }
                else if (file.FileTypeID.Equals(Guid.Parse("00000000-0000-0000-0000-000000000050")))
                {
                    foreach (DataRow row in csvTable.Rows)
                    {
                        DateTime naturalDay = DateTime.ParseExact(row[2].ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                        DateTime regDate = DateTime.ParseExact(row[6].ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                        DateTime uploadDate = DateTime.ParseExact(row[27].ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                        var historicalObject = new Historical
                        {
                            Id = Guid.NewGuid(),
                            Plate = (string)row[0],
                            Chassis = (string)row[1],
                            NaturalDay = naturalDay,
                            YearMonth = (string)row[3],
                            NaturalYear = (string)row[4],
                            OFMM = (string)row[5],
                            RegDate = regDate,
                            FMM_MTM = (string)row[7],
                            RegNum = (string)row[8],
                            Owner = (string)row[9],
                            Address = (string)row[10],
                            Province = (string)row[11],
                            Department = (string)row[12],
                            Location = (string)row[13],
                            PostalCode = (string)row[14],
                            Year = (string)row[15],
                            Car = (string)row[16],
                            ManufactureCountry = (string)row[17],
                            OriginCountry = (string)row[18],
                            CUITPref = (string)row[19],
                            PatQuantity = (string)row[20],
                            Weight = (string)row[21],
                            Origin = (string)row[22],
                            Motor = (string)row[23],
                            FactoryPat = (string)row[24],
                            BrandPat = (string)row[25],
                            CarModelPat = (string)row[26],
                            UploadDate = uploadDate,
                            OFMMError = (string)row[28],
                            IsPatDuplicated = (string)row[29],
                            CUITOwner = (string)row[30],
                        };
                        historicalObject.FileId = file.Id;
                        historicals.Add(historicalObject);
                    }
                    _historicalRepository.BulkInsert(historicals);
                }
                var userId = _contextAccessor?.HttpContext?.User;
                var eventFile = new EventFile
                {
                    Id = Guid.NewGuid(),
                    FileID = file.Id,
                    Status = dto.Status,
                    UserName = userId?.Identity?.Name ?? $"Anonymous"
                };

                var res = _eventFileRepository.InsertAndSave(eventFile);
                _azureService.deleteFileTemporal(fullPath);
                return new BaseResponse<File>(StatusCodes.Status200OK, file);
            }
            catch (Exception e)
            {
                return new BaseResponse<File>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath, Encoding.UTF8))
            {
                string[] headers = sr.ReadLine().Split(';');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public BaseResponse<dynamic> GetByFileId(Guid fileId, bool dispose = true)
        {
            try
            {
                if (fileId == Guid.Empty)
                    return new BaseResponse<dynamic>(StatusCodes.Status400BadRequest, "El parámetro fileId es requerido.");
                var file = Context.Files.Where(f => f.Id.Equals(fileId)).SingleOrDefault();

                if (file == null)
                {
                    var baseResponse = new BaseResponse<dynamic>(StatusCodes.Status200OK);
                    baseResponse.Result = null;
                    return baseResponse;
                }

                dynamic results = null;

                if (file.FileTypeID == Guid.Parse("00000000-0000-0000-0000-000000000010"))
                {
                    var dailies = (from e in Context.Dailies
                                  where e.FileId.Equals(fileId)
                                  select new DailySpa
                                  {
                                      Id = e.Id,
                                      AutoId = e.AutoId,
                                      FileId = e.FileId,
                                      Origen = e.Source,
                                      Dominio = e.Plate,
                                      Motor = e.Motor,
                                      Chasis = e.Chassis,
                                      FMM_MTM = e.FMM_MTM,
                                      Fabrica_Desc = e.Factory_D,
                                      Marca_Desc = e.Brand_D,
                                      Modelo_Desc = e.Model_D,
                                      Tipo_Desc = e.Type_D,
                                      Fecha_De_Inscr = e.Reg_Date,
                                      Nro_De_Reg = e.RegSec,
                                      Registro_Desc = e.Desc_Reg,
                                      Modo = e.Desc_Prov,
                                      Titular = e.Taxi,
                                      Cuit_Titular = e.CUIT,
                                      CreatedAt = e.CreatedAt,
                                      UpdatedAt = e.UpdatedAt,
                                  }).ToList();

                    results = dailies;
                }

                if (file.FileTypeID == Guid.Parse("00000000-0000-0000-0000-000000000020"))
                {
                    var wholesales = (from e in Context.Wholesales
                                     where e.FileId.Equals(fileId)
                                     select new WholesaleSpa
                                     {
                                         Id = e.Id,
                                         AutoId = e.AutoId,
                                         FileId = e.FileId,
                                         AñoMes = e.YearMonth,
                                         Cod_Marca = e.CodBrand,
                                         Marca = e.Brand,
                                         Cod_Modelo = e.CodModel,
                                         Modelo = e.Model,
                                         Cod_Grado = e.CodTrademark,
                                         Grado = e.Trademark,
                                         Cant_Puertas = e.DoorsQty,
                                         Cilindrada = e.Engine,
                                         Tipo_de_Motor = e.MotorType,
                                         Tipo_de_Combustible = e.FuelType,
                                         Potencia = e.Power,
                                         Unidad_de_Potencia = e.PowerUnit,
                                         Tipo_de_Vehiculo = e.VehicleType,
                                         Traccion = e.Traction,
                                         Cantidad_de_Marchas = e.GearsQty,
                                         Tipo_de_Transmision = e.TransmissionType,
                                         Cantidad_de_Ejes = e.AxleQty,
                                         Peso = e.Weight,
                                         Capacidad_de_Carga = e.LoadCapacity,
                                         Categoria = e.Category,
                                         Origen = e.Origin,
                                         Stock_Inicial = e.InitialStock,
                                         Import_ProdMes = e.Import_ProdMonth,
                                         Import_ProdAcum = e.Import_ProdAccum,
                                         Venta_Mes = e.MonthlySale,
                                         Venta_Acum = e.MonthlyAccum,
                                         Export_Mes = e.ExportMonthly,
                                         Export_Acum = e.ExportAccum,
                                         Sist_Ahorro_Mes = e.SavingSystemMonthly,
                                         Sist_Ahorro_Acum = e.SavingSystemAccum,
                                         Stock_Final = e.FinalStock,
                                         Stock_NoOk = e.NoOkStock,
                                         CreatedAt = e.CreatedAt,
                                         UpdatedAt = e.UpdatedAt,
                                     }).ToList();

                    results = wholesales;
                }

                if (file.FileTypeID == Guid.Parse("00000000-0000-0000-0000-000000000030"))
                {
                    var monthlies = (from e in Context.Monthlies
                                   where e.FileId.Equals(fileId)
                                   select new MonthlySpa
                                   {
                                       Id = e.Id,
                                       AutoId = e.AutoId,
                                       FileId = e.FileId,
                                       Origen = e.Source,
                                       Dominio = e.Plate,
                                       Motor = e.Motor,
                                       Chasis = e.Chassis,
                                       FMM_MTM = e.FMM_MTM,
                                       Fabrica_Desc = e.Factory_D,
                                       Marca_Desc = e.Brand_D,
                                       Modelo_Desc = e.Model_D,
                                       Tipo_Desc = e.Type_D,
                                       Fecha_De_Inscr = e.Reg_Date,
                                       Nro_De_Reg = e.RegSec,
                                       Registro_Desc = e.Desc_Reg,
                                       Modo = e.Mode,
                                       Titular = e.Owner,
                                       Prefijo_Cuit = e.CUIT_PREF,
                                       Direccion = e.Address,
                                       Provincia = e.COD_PRO,
                                       Provincia_Desc = e.DESC_PROV,
                                       Departamento = e.COD_DPT,
                                       Despartamento_Desc = e.DESC_DPT,
                                       Localidad = e.COD_LOC,
                                       Localidad_Desc = e.DESC_LOC,
                                       Ciudad = e.City,
                                       Codigo_Postal = e.Zip,
                                       Año_Modelo = e.Year_Model,
                                       Auto = e.CodCar,
                                       Pais_Fabricacion = e.CountryFA,
                                       Pais_Procedencia = e.CountryPR,
                                       Peso = e.Weight,
                                       Cuit_Titular = e.CUIT,
                                       CreatedAt = e.CreatedAt,
                                       UpdatedAt = e.UpdatedAt,
                                   }).ToList();

                    results = monthlies;
                }

                if (file.FileTypeID == Guid.Parse("00000000-0000-0000-0000-000000000040"))
                {
                    var specialSales = (from e in Context.SpecialSales
                                     where e.FileId.Equals(fileId)
                                     select new SpecialSaleSpa
                                     {
                                         Id = e.Id,
                                         AutoId = e.AutoId,
                                         FileId = e.FileId,
                                         CUIT_Titular = e.CuitOwner,
                                         Titular = e.Owner,
                                         Persona_Juridica = e.LegalEntity,
                                         Desc_Persona_Juridica = e.DescriptionLegalEntity,
                                         Clasificacion_Gubernamental = e.GovernmentalClassification,
                                         Desc_Clasificacion_Gubernamental = e.DescriptionGovernmentalClassification,
                                         Subclasificacion_Gubernamental = e.SubgovernmentalClassification,
                                         Desc_Subclasificacion_Gubernamental = e.DescriptionSubgovernmentalClassification,
                                         Clasificacion_CUIT = e.CuitClassification,
                                         Desc_Clasificacion_CUIT = e.DescriptionCuitClassification,
                                         Apertura1 = e.Aperture1,
                                         Desc_Apertura1 = e.DescriptionAperture1,
                                         Apertura2 = e.Aperture2,
                                         Desc_Apertura2 = e.DescriptionAperture2,
                                         Clasificacion_Logistica = e.LogisticClassification,
                                         Desc_Clasificacion_Logistica = e.DescriptionLogisticClassification,
                                         Facturacion_Estimada = e.EstimatedTurnover,
                                         Desc_Facturacion_Estimada = e.DescriptionEstimatedTurnover,
                                         Fecha_de_Contrato_Social = e.SocialContractDate,
                                         Info_Empleados = e.EmployeesInfo,
                                         CreatedAt = e.CreatedAt,
                                         UpdatedAt = e.UpdatedAt,
                                     }).ToList();
                    results = specialSales;
                }
                if (file.FileTypeID == Guid.Parse("00000000-0000-0000-0000-000000000050"))
                {
                    var historicals = (from e in Context.Historicals
                                        where e.FileId.Equals(fileId)
                                        select new HistoricalSpa
                                        {
                                            Id = e.Id,
                                            AutoId = e.AutoId,
                                            FileId = e.FileId,
                                            Dominio = e.Plate,
                                            Chasis = e.Chassis,
                                            Dia_Natural = e.NaturalDay,
                                            AñoNatural_Mes = e.YearMonth,
                                            Año_Natural = e.NaturalYear,
                                            OFMM = e.OFMM,
                                            Fecha_de_Inscr = e.RegDate,
                                            FMM_MTM = e.FMM_MTM,
                                            Nro_De_Reg = e.RegNum,
                                            Titular = e.Owner,
                                            Direccion = e.Address,
                                            Provincia = e.Province,
                                            Departamento = e.Department,
                                            Localidad = e.Location,
                                            Codigo_Postal = e.PostalCode,
                                            Año = e.Year,
                                            Auto = e.Car,
                                            Pais_Fabricacion = e.ManufactureCountry,
                                            Pais_Procedencia = e.OriginCountry,
                                            CUIT_Pref = e.CUITPref,
                                            Cantidad_de_Patentamientos = e.PatQuantity,
                                            Peso = e.Weight,
                                            Origen = e.Origin,
                                            Motor = e.Motor,
                                            Fabrica_Pat = e.FactoryPat,
                                            Marca_Pat = e.BrandPat,
                                            Modelo_Pat = e.CarModelPat,
                                            Fecha_de_Carga = e.UploadDate,
                                            OFMM_Error = e.OFMMError,
                                            Es_Pat_Duplicado = e.IsPatDuplicated,
                                            CUIT_Titular = e.CUITOwner,
                                            CreatedAt = e.CreatedAt,
                                            UpdatedAt = e.UpdatedAt,
                                        }).ToList();
                    results = historicals;
                }

                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);

            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                if (dispose)
                 Dispose();
            }
        }

        public BaseResponse<File> Update(FileCreateOrUpdateDto dto)
        {
            try
            {
                var fileResponse = GetSingle(u => u.Id.Equals(dto.Id));
                if (fileResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<File>(StatusCodes.Status400BadRequest, fileResponse.Message, fileResponse.StackTrace);
                var file = fileResponse.Result;
                file.Name = dto.Name;
                file.Status = dto.Status;
                file.RecordQuantity = dto.RecordQuantity;
                file.URL = dto.URL;
                file.Date = dto.Date;
                file.Day = dto.Day;
                file.Month = dto.Month;
                file.Year = dto.Year;
                file.FileTypeID = dto.FileTypeID;
                UpdateAndSave(file);
                var findEventFile = Context.EventFiles.Where(ef => ef.FileID.Equals((Guid)dto.Id)).FirstOrDefault();
                var userId = _contextAccessor?.HttpContext?.User;
                findEventFile.IsDeleted = true;
                    _eventFileRepository.UpdateAndSave(findEventFile);
                    var newEventFile = new EventFile
                    {
                        Id = Guid.NewGuid(),
                        FileID = (Guid)dto.Id,
                        Status = dto.Status,
                        UserName = userId?.Identity?.Name ?? $"Anonymous"
                    };
                _eventFileRepository.InsertAndSave(newEventFile);
                return new BaseResponse<File>(StatusCodes.Status200OK, file);
            }
            catch (Exception e)
            {
                return new BaseResponse<File>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public BaseResponse<dynamic> DeleteFile(Guid fileId)
        {
            try
            {
                var param = new SqlParameter { ParameterName = "fileId", Value = fileId };
                var result = Context.Database.ExecuteSqlRaw("EXECUTE [dbo].[usp_deteleFile] @fileId", param);
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
    }
}
