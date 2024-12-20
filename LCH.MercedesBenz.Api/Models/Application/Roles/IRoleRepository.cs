using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Roles
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        BaseResponse<RoleDto> GetAll(string? orderBy = null, Direction direction = Direction.None);
        BaseResponse<RoleDto> GetAll3();
    }
}
