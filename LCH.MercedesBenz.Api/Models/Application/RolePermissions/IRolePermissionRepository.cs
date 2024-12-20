namespace LCH.MercedesBenz.Api.Models.Application.RolePermissions
{
    public interface IRolePermissionRepository : IBaseRepository<RolePermission>
    {
        BaseResponse<bool> DeleteAll(string? roleId = null, bool dispose = true);
    }
}
