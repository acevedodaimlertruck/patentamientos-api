using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.RolePermissions;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class RolePermissionsController : BaseController<RolePermission>
    {
        private readonly IBaseRepository<RolePermission> _repository;
        private readonly ILogger<RolePermissionsController> _logger;
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public RolePermissionsController(
            IBaseRepository<RolePermission> repository,
            ILogger<RolePermissionsController> logger,
            IRolePermissionRepository rolePermissionRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _rolePermissionRepository = rolePermissionRepository;
        }
    }
}
