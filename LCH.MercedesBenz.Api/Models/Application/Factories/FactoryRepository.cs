using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Provinces;

namespace LCH.MercedesBenz.Api.Models.Application.Factories
{
    public class FactoryRepository : BaseRepository<Factory>, IFactoryRepository
    {
        private readonly IMapper _mapper;
        public FactoryRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context) 
        {
            _mapper = mapper;
        }

        public BaseResponse<FactoryDto> GetAll2()
        {
            try
            {
                var results = Context.Factories.Select(i => new FactoryDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    MercedesFabricaId = i.MercedesFabricaId
                }).OrderBy(i => i.Name).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<FactoryDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FactoryDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Factory> Create(FactoryDto dto)
        {
            try
            {
                var entity = Context.Factories.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<Factory>(StatusCodes.Status400BadRequest, $"La fábrica ya existe.");
                entity = _mapper.Map<Factory>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Factory>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Factory>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Factory> Update(FactoryDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Factory>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Factories.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Factory>(StatusCodes.Status400BadRequest, $"Id de fábrica no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Factory>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Factory>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public dynamic addJson(dynamic json)
        {
            try
            {
                foreach (var js in json)
                {
                    var fact = new Factory();
                    fact.Name = js.TXTSH;
                    fact.Description = js.TXTSH;
                    fact.MercedesFabricaId = js.idfabrica;
                    Context.Factories.Add(fact);
                }
                Context.SaveChanges();
                return null;
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

        public dynamic addJsonProv(dynamic json)
        {
            try
            {
                foreach (var js in json)
                {
                    var fact = new Province();
                    fact.Name = js.TXTSH;
                    fact.Description = js.TXTSH;
                    fact.MercedesProvinciaId = js.idprov;
                    // Agrega la persona a la base de datos
                    Context.Provinces.Add(fact);
                }
                Context.SaveChanges();
                return null;
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
