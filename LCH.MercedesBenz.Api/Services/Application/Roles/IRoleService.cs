using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;

namespace LCH.MercedesBenz.Api.Services.Application.Roles
{
    public interface IRoleService
    {
        BaseResponse<Role> Create(RoleCreateDto dto);

        BaseResponse<Role> Update(RoleUpdateDto dto);

        BaseResponse<bool> UpdatePermissions(RoleDto roleDto);
    }
}
