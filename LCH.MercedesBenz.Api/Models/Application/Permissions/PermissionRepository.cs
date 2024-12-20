using LCH.MercedesBenz.Api.Models.Application.Permissions.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Permissions
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public BaseResponse<PermissionDto> GetByRoleId(Guid roleId)
        {
            try
            {
                var results = Context.Permissions.Select(e => new PermissionDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    Ordering = e.Ordering,
                    Granted = e.RolePermissions.Any(rp => rp.RoleId.Equals(roleId))
                }).OrderBy(e => e.Ordering).ToList();
                return new BaseResponse<PermissionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PermissionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<PermissionDto> GetGrantedByRoleId(Guid roleId)
        {
            try
            {
                var results = (from p in Context.Permissions
                               join rp in Context.RolePermissions on p.Id equals rp.PermissionId
                               where rp.RoleId.Equals(roleId)
                               select new PermissionDto
                               {
                                   Id = p.Id,
                                   Name = p.Name,
                                   Description = p.Description,
                                   Ordering = p.Ordering,
                                   Granted = true
                               }).OrderBy(e => e.Ordering).ToList();
                return new BaseResponse<PermissionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PermissionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
