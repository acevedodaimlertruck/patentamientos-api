using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Departments;
using LCH.MercedesBenz.Api.Models.Application.Provinces;
using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace LCH.MercedesBenz.Api.Models.Application.RegSecs
{
    public class RegSecRepository : BaseRepository<RegSec>, IRegSecRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public RegSecRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _context=context;
            _mapper = mapper;
        }

        public BaseResponse<RegSecDto> GetAll2()
        {
            try
            {
                var results = Context.RegSecs.Select(i => new RegSecDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    RegistryNumber = i.RegistryNumber,
                    RegistryProvince = i.RegistryProvince,
                    RegistryDepartment = i.RegistryDepartment,
                    RegistryLocation = i.RegistryLocation,
                    AutoZoneDealer = i.AutoZoneDealer,
                    AutoZoneDescription = i.AutoZoneDescription,
                    TruckZoneDealer = i.TruckZoneDealer,
                    TruckZoneDescription = i.TruckZoneDescription,
                    VanZoneDealer = i.VanZoneDealer,
                    VanZoneDescription = i.VanZoneDescription,
                    //ProvinceId = i.ProvinceId,
                    //DepartmentId = i.DepartmentId,
                    //LocationId = i.LocationId,
                }).OrderBy(i => i.Name).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<RegSecDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<RegSecDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<RegSec> UploadFile(RegSecUpload formUpload)
        {
            try
            {
                var fileUpload = formUpload.Base64!.Substring(formUpload.Base64.LastIndexOf(',') + 1);
                var bytess = Convert.FromBase64String(fileUpload);
                var upload = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
                if (!Directory.Exists(upload))
                    Directory.CreateDirectory(upload);
                var fullPath = Path.Combine(upload, formUpload.FileName!);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    fileStream.Write(bytess, 0, bytess.Length);
                    fileStream.Flush();
                }
                var csvTable = ConvertCSVtoDataTable(fullPath);
                var regSecs = new List<RegSec>();

                foreach (DataRow row in csvTable.Rows)
                {
                    var registryNumber = (string)row[1];
                    var autoZoneDealer = (string)row[5];
                    var truckZoneDealer = (string)row[7];
                    var vanZoneDealer = (string)row[9];
                    var existingRegSec = ExistingRegSec(registryNumber, autoZoneDealer, truckZoneDealer, vanZoneDealer);

                    //var provinceCode = (string)row[11];
                    //var departmentCode = (string)row[12];
                    //var locationCode = (string)row[13];

                    //var locationId = Context.Locations
                    //    .Where(p => p.MercedesLocalidadId == locationCode && p.MercedesDepartamentoId == departmentCode && p.MercedesProvinciaId == provinceCode)
                    //    .Select(p => p.Id)
                    //    .FirstOrDefault();

                    //var departmentId = Context.Departments
                    //           .Where(p => p.MercedesDepartamentoId == departmentCode && p.MercedesProvinciaId == provinceCode)
                    //           .Select(p => p.Id)
                    //           .FirstOrDefault();

                    //var provinceId = Context.Provinces
                    //           .Where(p => p.MercedesProvinciaId == provinceCode)
                    //           .Select(p => p.Id)
                    //           .FirstOrDefault();

                    //if (locationId == default(Guid) || departmentId == default(Guid) || provinceId == default(Guid))
                    //{ 
                    //     locationId = Guid.Parse("00000000-0000-0000-0000-000000000033");
                    //     departmentId = Guid.Parse("00000000-0000-0000-0000-000000000033");
                    //     provinceId = Guid.Parse("00000000-0000-0000-0000-000000000033");
                    //}

                    if (existingRegSec != null)
                    {
                        // Caso 1: Registro Existente 
                        existingRegSec.Name = (string)row[0];
                        existingRegSec.Description = (string)row[0];
                        existingRegSec.RegistryProvince = (string)row[2];
                        existingRegSec.RegistryDepartment = (string)row[3];
                        existingRegSec.RegistryLocation = (string)row[4];
                        existingRegSec.AutoZoneDescription = (string)row[6];
                        existingRegSec.TruckZoneDescription = (string)row[8];
                        existingRegSec.VanZoneDescription = (string)row[10];
                        //existingRegSec.ProvinceId = provinceId;
                        //existingRegSec.DepartmentId = departmentId;
                        //existingRegSec.LocationId = locationId;
                        existingRegSec.CreatedAt = DateTime.Now; 
                        UpdateAndSave(existingRegSec);
                    }
                    else
                    {
                        // Caso 2: Nuevo Registro 
                        var regSecObject = new RegSec
                        {
                            Name = (string)row[0],
                            Description = (string)row[0],
                            RegistryNumber = registryNumber,
                            RegistryProvince = (string)row[2],
                            RegistryDepartment = (string)row[3],
                            RegistryLocation = (string)row[4],
                            AutoZoneDealer = autoZoneDealer,
                            AutoZoneDescription = (string)row[6],
                            TruckZoneDealer = truckZoneDealer,
                            TruckZoneDescription = (string)row[8],
                            VanZoneDealer = vanZoneDealer,
                            VanZoneDescription = (string)row[10],
                            //ProvinceId = provinceId,
                            //DepartmentId = departmentId,
                            //LocationId = locationId,
                            CreatedAt = DateTime.Now                           
                        }; 
                        regSecs.Add(regSecObject);
                    }
                }
                
                BulkInsert(regSecs);
                if (File.Exists(Path.Combine(fullPath))) 
                    File.Delete(Path.Combine(fullPath));
                return new BaseResponse<RegSec>(StatusCodes.Status200OK, regSecs);
            }
            catch (Exception e)
            {
                return new BaseResponse<RegSec>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        private RegSec ExistingRegSec(string registryNumber, string autoZoneDealer,  string truckZoneDealer, string vanZoneDealer)
        { 
            return Context.RegSecs.FirstOrDefault(r => r.RegistryNumber == registryNumber && r.AutoZoneDealer == autoZoneDealer && r.TruckZoneDealer == truckZoneDealer && r.VanZoneDealer == vanZoneDealer);
        }
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath, Encoding.GetEncoding("ISO-8859-1")))
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

        public BaseResponse<RegSec> Create(RegSecDto dto)
        {
            try
            {
                var entity = Context.RegSecs.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<RegSec>(StatusCodes.Status400BadRequest, $"El registro ya existe.");
                entity = _mapper.Map<RegSec>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<RegSec>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<RegSec>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<RegSec> Update(RegSecDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<RegSec>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.RegSecs.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<RegSec>(StatusCodes.Status400BadRequest, $"Id de grado no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<RegSec>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<RegSec>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
