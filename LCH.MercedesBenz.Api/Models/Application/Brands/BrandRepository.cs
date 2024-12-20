using AutoMapper;
using Humanizer;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Brands
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        private readonly IMapper _mapper;
        public BrandRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context) 
        {
            _mapper = mapper;
        }

        public BaseResponse<BrandDto> GetAll2()
        {
            try
            {
                var results = Context.Brands.Select(i => new BrandDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    TerminalId = i.TerminalId,
                    Terminal = i.Terminal == null ? null : new TerminalDto
                    {
                        Id = i.Terminal.Id,
                        Name = i.Terminal.Name,
                        Description = i.Terminal.Description,
                        MercedesTerminalId = i.Terminal.MercedesTerminalId
                    },
                    MercedesTerminalId = i.MercedesTerminalId,
                    MercedesMarcaId = i.MercedesMarcaId
                }).OrderBy(i => i.MercedesMarcaId).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<BrandDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<BrandDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Brand> Create(BrandDto dto)
        {
            try
            {
                var entity = Context.Brands.SingleOrDefault(p => p.MercedesMarcaId!.Equals(dto.MercedesMarcaId) && p.MercedesTerminalId!.Equals(dto.MercedesTerminalId));
                if (entity != null)
                    return new BaseResponse<Brand>(StatusCodes.Status400BadRequest, $"ID de marca existente: '{entity.Description}'.");
                entity = _mapper.Map<Brand>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Brand>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Brand>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Brand> Update(BrandDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Brand>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Brands.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Brand>(StatusCodes.Status400BadRequest, $"Id de la marca no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Brand>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Brand>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                    var fact = new Brand();
                    fact.Name = js.TXTSH;
                    fact.Description = js.TXTSH;
                    fact.MercedesMarcaId = js.idmarca;
                    fact.MercedesTerminalId = null;
                    // Agrega la persona a la base de datos
                    Context.Brands.Add(fact);
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
