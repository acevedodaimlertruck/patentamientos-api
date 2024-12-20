using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Users
{
    public interface IUserRepository : IBaseRepository<User>
    {
        BaseResponse<UserSignInResponseDto> SignIn(string userName, string password);

        BaseResponse<string> RefreshToken(Guid userId);

        BaseResponse<UserSignInResponseDto> SignInWithPin(string userName, string pin, string secretKey, int expires);

        BaseResponse<UserSignInResponseDto> SetPwd(SetPwdDto setPwdDto);

        BaseResponse<int> Count(List<Filter> filters);

        BaseResponse<QueryDto<UserDto>> Paginate(QueryDto<UserDto> page);

        BaseResponse<UserDto> GetById2(Guid id);

        BaseResponse<string> CreatePin(string id, string newPin, string confirmPin);

        BaseResponse<string> UpdatePin(string id, string pin, string newPin, string confirmPin);
    }
}
