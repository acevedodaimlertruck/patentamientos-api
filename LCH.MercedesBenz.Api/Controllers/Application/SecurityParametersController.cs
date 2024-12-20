using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.SecurityParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/SecurityParameter")]
    public class SecurityParametersController : BaseController<SecurityParameter>
    {
        private readonly IBaseRepository<SecurityParameter> _repository;
        private readonly ILogger<SecurityParametersController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISecurityParameterRepository _securityParameterRepository;

        public SecurityParametersController(
            IBaseRepository<SecurityParameter> repository, 
            ILogger<SecurityParametersController> logger, 
            IConfiguration configuration,
            ISecurityParameterRepository securityParameterRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _securityParameterRepository = securityParameterRepository;
            BaseControllerOptions.Add = true;
            BaseControllerOptions.Edit = true;
        }

        [AllowAnonymous]
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _securityParameterRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
