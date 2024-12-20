using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;
using LCH.MercedesBenz.Api.Services.Application.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class RolesController : BaseController<Role>
    {
        private readonly IBaseRepository<Role> _repository;
        private readonly ILogger<RolesController> _logger;
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleService _roleService;

        public RolesController(
            IBaseRepository<Role> repository,
            ILogger<RolesController> logger,
            IRoleRepository roleRepository,
            IRoleService roleService) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _roleRepository = roleRepository;
            _roleService = roleService;
            BaseControllerOptions.GetAll = true;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll(string? by = null, Direction direction = Direction.None)
        {
            var response = _roleRepository.GetAll(by, direction);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all3")]
        public IActionResult GetAll3()
        {
            var response = _roleRepository.GetAll3();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update-permissions")]
        public IActionResult UpdatePermissions(RoleDto role)
        {
            var response = _roleService.UpdatePermissions(role);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(RoleCreateDto dto)
        {
            var response = _roleService.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(RoleUpdateDto dto)
        {
            var response = _roleService.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
