using LCH.MercedesBenz.Api.Models.Application.Permissions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Permissions
{
    public interface IPermissionRepository : IBaseRepository<Permission>
    {
        BaseResponse<PermissionDto> GetByRoleId(Guid roleId);

        BaseResponse<PermissionDto> GetGrantedByRoleId(Guid roleId);
    }
}
