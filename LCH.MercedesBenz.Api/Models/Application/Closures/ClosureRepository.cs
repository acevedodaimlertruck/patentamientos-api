using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Closures.Dtos;
using LCH.MercedesBenz.Api.Models.Application.TMMVS;

namespace LCH.MercedesBenz.Api.Models.Application.Closures
{
    public class ClosureRepository : BaseRepository<Closure>, IClosureRepository
    {
        private readonly IMapper _mapper;

        public ClosureRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<ClosureDto> GetAll2()
        {
            try
            {
                var results = Context.Closures.Select(i => new ClosureDto
                {
                    Id = i.Id,
                    FechaCorte = i.FechaCorte,
                    FechaCreacion = i.FechaCreacion,
                    HoraCreacion = i.HoraCreacion,
                    EsUltimo = i.EsUltimo
                }).OrderBy(i => i.EsUltimo).ToList();
                return new BaseResponse<ClosureDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClosureDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Closure> Create(ClosureDto dto)
        {
            try
            {
                var entity = Context.Closures.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<Closure>(StatusCodes.Status400BadRequest, $"El cierre ya existe como último.");
                entity = _mapper.Map<Closure>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                var lastClosure = Context.Closures.FirstOrDefault(c => c.EsUltimo.Equals(true));
                if ((lastClosure != null) && (lastClosure.FechaCorte != dto.FechaCorte))
                {
                    lastClosure.EsUltimo = false;
                    InsertAndSave(entity);
                }
                return new BaseResponse<Closure>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Closure>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                    var fact = new Closure();
                    long time = js.ZFEC_CIERRE;
                    long time1 = js.ZFEC_DIA;
                    fact.FechaCorte = DateTimeOffset.FromUnixTimeMilliseconds(time).UtcDateTime;
                    fact.FechaCreacion = DateTimeOffset.FromUnixTimeMilliseconds(time1).UtcDateTime;
                    fact.HoraCreacion = js.ZHORA_DIA;

                    Context.Closures.Add(fact);
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
