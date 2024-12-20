using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Users;
using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;

namespace LCH.MercedesBenz.Api.Services.Application.Users
{
    public interface IUserService
    {
        BaseResponse<User> Create(UserCreateDto dto);

        BaseResponse<User> CreateOrUpdate(UserUpdateDto dto);

        BaseResponse<User> Update(UserUpdateDto dto);
    }
}
