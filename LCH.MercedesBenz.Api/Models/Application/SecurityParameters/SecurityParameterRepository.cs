using LCH.MercedesBenz.Api.Models.Application.SecurityParameters.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SecurityParameters
{
    public class SecurityParameterRepository : BaseRepository<SecurityParameter>, ISecurityParameterRepository
    {
        public SecurityParameterRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }
        public BaseResponse<SecurityParameterDto> GetAll2(bool dispose = true)
        {
            try
            {
                var results = Context.SecurityParameters.Select(c => new SecurityParameterDto
                {
                    Id = c.Id,
                    SessionTime = c.SessionTime,
                    NumberLogins =c.NumberLogins,
                    MinCharacters = c.MinCharacters,
                    MaxCharacters = c.MaxCharacters,
                    IncludeCapitalLetter = c.IncludeCapitalLetter,
                    IncludeNumbers = c.IncludeNumbers,
                    IncludeSpecialCharacters = c.IncludeSpecialCharacters
                }).OrderBy(c => c.SessionTime).ToList();
                return new BaseResponse<SecurityParameterDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SecurityParameterDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                if (dispose)
                    Dispose();
            }
        }
    }
}
