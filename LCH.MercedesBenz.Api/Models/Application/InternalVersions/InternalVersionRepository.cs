using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions
{
    public class InternalVersionRepository : BaseRepository<InternalVersion>, IInternalVersionRepository
    {
        private readonly IMapper _mapper;

        public InternalVersionRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<InternalVersionDto> GetAll2()
        {
            try
            {
                var results = Context.InternalVersions.Select(i => new InternalVersionDto
                {
                    Id = i.Id,
                   MercedesMarcaId = i.MercedesMarcaId,
                   CarModelId = i.CarModelId,
                   CarModel = i.CarModel == null ? null : new CarModelDto
                   {
                       Id = i.CarModel.Id,
                       Name = i.CarModel.Name,
                       Description = i.CarModel.Description,
                       MercedesTerminalId = i.CarModel.MercedesTerminalId,
                       MercedesMarcaId = i.CarModel.MercedesMarcaId,
                       MercedesModeloId = i.CarModel.MercedesModeloId,
                       BrandId = i.CarModel.BrandId,
                       Brand = i.CarModel.Brand == null ? null : new BrandDto
                       {
                           Id = i.CarModel.Brand.Id,
                           Name = i.CarModel.Brand.Name,
                           TerminalId = i.CarModel.Brand.TerminalId,
                           Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                           {
                               Id = i.CarModel.Brand.Terminal.Id,
                               Name = i.CarModel.Brand.Terminal.Name
                           }
                       }
                   },
                   MercedesModeloId = i.MercedesModeloId,
                   MercedesTerminalId = i.MercedesTerminalId,
                   VersionPatentamiento = i.VersionPatentamiento,
                   VersionWs = i.VersionWs,
                   VersionInterna = i.VersionInterna,
                   DescripcionVerInt = i.DescripcionVerInt,
                   UploadDate = i.UploadDate,
                   DateTo = i.DateTo,
                   DateFrom = i.DateFrom
                }).OrderBy(i => i.VersionInterna).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<InternalVersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<InternalVersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<InternalVersion> Create(InternalVersionDto dto)
        {
            try
            {
                var entity = Context.InternalVersions.SingleOrDefault(p => p.VersionInterna!.Equals(dto.VersionInterna));
                if (entity != null)
                    return new BaseResponse<InternalVersion>(StatusCodes.Status400BadRequest, $"La Versión Interna ya existe.");
                entity = _mapper.Map<InternalVersion>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<InternalVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<InternalVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<InternalVersion> Update(InternalVersionDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<InternalVersion>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.InternalVersions.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<InternalVersion>(StatusCodes.Status400BadRequest, $"Id de Versión Interna no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<InternalVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<InternalVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<int> GetLastId()
        {
            try
            {
                var results = Context.InternalVersions.AsEnumerable().Select(iv => int.TryParse(iv.VersionInterna, out var intValue) ? intValue : -1).Max();
                return new BaseResponse<int>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<int>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
