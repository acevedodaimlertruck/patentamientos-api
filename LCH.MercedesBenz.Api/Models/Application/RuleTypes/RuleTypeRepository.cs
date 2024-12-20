using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.RuleTypes
{
    public class RuleTypeRepository : BaseRepository<RuleType>, IRuleTypeRepository
    {
        private readonly IMapper _mapper;

        public RuleTypeRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<RuleTypeDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<RuleTypeDto>();
                Expression<Func<RuleType, RuleTypeDto>> selector = e => new RuleTypeDto
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
                    results = Context.RuleTypes.Select(selector).ToList();
                    return new BaseResponse<RuleTypeDto>(StatusCodes.Status200OK, results);
                }
                Func<RuleTypeDto, object> orderBy;
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
                    results = Context.RuleTypes.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<RuleTypeDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.RuleTypes.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<RuleTypeDto>(StatusCodes.Status200OK, results);
                }
                results = Context.RuleTypes.Select(selector).ToList();
                return new BaseResponse<RuleTypeDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<RuleTypeDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
