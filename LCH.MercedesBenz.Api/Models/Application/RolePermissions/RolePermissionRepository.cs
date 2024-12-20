using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.RolePermissions
{
    public class RolePermissionRepository : BaseRepository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public BaseResponse<bool> DeleteAll(string? roleId = null, bool dispose = true)
        {
            try
            {
                var sqlQuery = $"DELETE FROM RolePermissions";
                if (!string.IsNullOrEmpty(roleId))
                    sqlQuery += $" WHERE RoleId = '{roleId}';";
                else
                    sqlQuery += ";";
                Context.Database.ExecuteSqlRaw(sqlQuery);
                return new BaseResponse<bool>(StatusCodes.Status200OK, true);
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                if (dispose)
                    Dispose();
            }
        }
    }
}