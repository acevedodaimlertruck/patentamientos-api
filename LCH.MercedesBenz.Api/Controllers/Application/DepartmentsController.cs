using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Departments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Departments")]
    public class DepartmentsController : BaseController<Department>
    {
        private readonly IBaseRepository<Department> _repository;
        private readonly ILogger<DepartmentsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(
            IBaseRepository<Department> repository, 
            ILogger<DepartmentsController> logger, 
            IConfiguration configuration, 
            IDepartmentRepository departmentRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _departmentRepository = departmentRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _departmentRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
