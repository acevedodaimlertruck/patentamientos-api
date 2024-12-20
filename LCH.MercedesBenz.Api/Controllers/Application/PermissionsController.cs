using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class PermissionsController : BaseController<Permission>
    {
        private readonly IBaseRepository<Permission> _repository;
        private readonly ILogger<PermissionsController> _logger;
        private readonly IPermissionRepository _permissionRepository;

        public PermissionsController(
            IBaseRepository<Permission> repository,
            ILogger<PermissionsController> logger,
            IPermissionRepository permissionRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _permissionRepository = permissionRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("by-rid")]
        public IActionResult GetByRoleId(Guid roleId)
        {
            var response = _permissionRepository.GetByRoleId(roleId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("granted")]
        public IActionResult GetGrantedByRoleId(Guid roleId)
        {
            var response = _permissionRepository.GetGrantedByRoleId(roleId);
            return StatusCode(response.StatusCode, response);
        }
    }
}
