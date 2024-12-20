using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Powers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Powers")]
    public class PowersController : BaseController<Power>
    {
        private readonly IBaseRepository<Power> _repository;
        private readonly ILogger<PowersController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IPowerRepository _powerRepository;

        public PowersController(
            IBaseRepository<Power> repository, 
            ILogger<PowersController> logger, 
            IConfiguration configuration, 
            IPowerRepository powerRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _powerRepository = powerRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _powerRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
