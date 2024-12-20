using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.StatePatentas
{
    public class StatePatentaRepository : BaseRepository<StatePatenta>, IStatePatentaRepository
    {
        private readonly IMapper _mapper;

        public StatePatentaRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<StatePatentaDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<StatePatentaDto>();
                Expression<Func<StatePatenta, StatePatentaDto>> selector = e => new StatePatentaDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    Name = e.Name,
                    Description = e.Description,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.StatePatentas.Select(selector).ToList();
                    return new BaseResponse<StatePatentaDto>(StatusCodes.Status200OK, results);
                }
                Func<StatePatentaDto, object> orderBy;
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
                    results = Context.StatePatentas.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<StatePatentaDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.StatePatentas.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<StatePatentaDto>(StatusCodes.Status200OK, results);
                }
                results = Context.StatePatentas.Select(selector).ToList();
                return new BaseResponse<StatePatentaDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<StatePatentaDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
