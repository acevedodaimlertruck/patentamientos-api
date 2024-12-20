using AutoMapper;

namespace LCH.MercedesBenz.Api.Models.Application.RulePatentings
{
    public class RulePatentingRepository : BaseRepository<RulePatenting>, IRulePatentingRepository
    {
        private readonly IMapper _mapper;

        public RulePatentingRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        //public BaseResponse<RuleDto> GetAll(string? by = null, Direction direction = Direction.None)
        //{
        //    try
        //    {
        //        var results = new List<RuleDto>();
        //        Expression<Func<Rule, RuleDto>> selector = e => new RuleDto
        //        {
        //            Id = e.Id,
        //            AutoId = e.AutoId,
        //            Name = e.Name,
        //            Description = e.Description,
        //            CreatedAt = e.CreatedAt,
        //            UpdatedAt = e.UpdatedAt,
        //        };
        //        if (string.IsNullOrEmpty(by))
        //        {
        //            results = Context.Rules.Select(selector).ToList();
        //            return new BaseResponse<RuleDto>(StatusCodes.Status200OK, results);
        //        }
        //        Func<RuleTypeDto, object> orderBy;
        //        switch (by)
        //        {
        //            case "AutoId":
        //                orderBy = e => e.AutoId;
        //                break;
        //            case "Name":
        //                orderBy = e => e.Name;
        //                break;
        //            case "UpdatedAt":
        //                orderBy = e => e.UpdatedAt;
        //                break;
        //            default:
        //                orderBy = e => e.CreatedAt;
        //                break;
        //        }
        //        if (direction == Direction.Ascending)
        //        {
        //            results = Context.Rules.Select(selector).OrderBy(orderBy).ToList();
        //            return new BaseResponse<RuleDto>(StatusCodes.Status200OK, results);
        //        }
        //        if (direction == Direction.Descending)
        //        {
        //            results = Context.Rules.Select(selector).OrderByDescending(orderBy).ToList();
        //            return new BaseResponse<RuleDto>(StatusCodes.Status200OK, results);
        //        }
        //        results = Context.Rules.Select(selector).ToList();
        //        return new BaseResponse<RuleDto>(StatusCodes.Status200OK, results);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BaseResponse<RuleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
        //    }
        //    finally
        //    {
        //        Dispose();
        //    }
        //}
    }
}
