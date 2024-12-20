using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Usages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Usages")]
    public class UsagesController : BaseController<Usage>
    {
        private readonly IBaseRepository<Usage> _repository;
        private readonly ILogger<UsagesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUsageRepository _usageRepository;

        public UsagesController(
            IBaseRepository<Usage> repository, 
            ILogger<UsagesController> logger, 
            IConfiguration configuration, 
            IUsageRepository usageRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _usageRepository = usageRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _usageRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
