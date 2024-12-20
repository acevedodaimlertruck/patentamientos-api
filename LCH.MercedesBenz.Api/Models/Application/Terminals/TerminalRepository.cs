using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using AutoMapper;

namespace LCH.MercedesBenz.Api.Models.Application.Terminals
{
    public class TerminalRepository : BaseRepository<Terminal>, ITerminalRepository
    {
        private readonly IMapper _mapper;
        public TerminalRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<TerminalDto> GetAll2()
        {
            try
            {
                var results = Context.Terminals.Select(i => new TerminalDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    MercedesTerminalId = i.MercedesTerminalId
                }).OrderBy(i => i.MercedesTerminalId).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<TerminalDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<TerminalDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Terminal> Create(TerminalDto dto)
        {
            try
            {
                var entity = Context.Terminals.SingleOrDefault(p => p.MercedesTerminalId!.Equals(dto.MercedesTerminalId));
                if (entity != null)
                    return new BaseResponse<Terminal>(StatusCodes.Status400BadRequest, $"ID de terminal existente: '{entity.Description}'.");
                entity = _mapper.Map<Terminal>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Terminal>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Terminal>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Terminal> Update(TerminalDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Terminal>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Terminals.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Terminal>(StatusCodes.Status400BadRequest, $"Id de terminal no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Terminal>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Terminal>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                    var fact = new Terminal();
                    fact.Name = js.TXTMD != null ? js.TXTMD : "Sin nombre";
                    fact.Description = js.TXTMD;
                    fact.MercedesTerminalId = js.idterm;
                    // Agrega la persona a la base de datos
                    Context.Terminals.Add(fact);
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
