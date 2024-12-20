using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.PatentingVersions
{
    public class PatentingVersionRepository : BaseRepository<PatentingVersion>, IPatentingVersionRepository
    {
        private readonly IMapper _mapper;

        public PatentingVersionRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<PatentingVersionDto> GetAll2()
        {
            try
            {
                var results = Context.PatentingVersions.Select(i => new PatentingVersionDto
                {

                    Id = i.Id, 
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
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId,
                    MercedesTerminalId = i.MercedesTerminalId,  
                   Version  = i.Version , 
                   Description  = i.Description 
                }).OrderBy(i => i.Version ).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<PatentingVersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PatentingVersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<PatentingVersion> Create(PatentingVersionDto dto)
        {
            try
            {
                var entity = Context.PatentingVersions.FirstOrDefault(p => p.CarModelId!.Equals(dto.CarModelId) &&  p.Version!.Equals(dto.Version));
                if (entity != null)
                    return new BaseResponse<PatentingVersion>(StatusCodes.Status400BadRequest, $"Esta Versión de Patentamiento ya existe.");
                entity = _mapper.Map<PatentingVersion>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<PatentingVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<PatentingVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<PatentingVersion> Update(PatentingVersionDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<PatentingVersion>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.PatentingVersions.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<PatentingVersion>(StatusCodes.Status400BadRequest, $"Id de Versión de Patentamiento no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<PatentingVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<PatentingVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                var results = Context.PatentingVersions.AsEnumerable().Select(iv => int.TryParse(iv.Version, out var intValue) ? intValue : -1).Max();
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
