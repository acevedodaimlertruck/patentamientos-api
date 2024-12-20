using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Rules.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Rules
{
    public class RuleRepository : BaseRepository<Rule>, IRuleRepository
    {
        private readonly IMapper _mapper;

        public RuleRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<RuleDto> GetAll2()
        {
            try
            {
                var results = Context.Rules.Select(i => new RuleDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    Code = i.Code
                }).OrderBy(i => i.Code).ToList();
                return new BaseResponse<RuleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<RuleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
