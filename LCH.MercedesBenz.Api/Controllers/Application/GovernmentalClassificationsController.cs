using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/GovernmentalClassifications")]
    public class GovernmentalClassificationsController : BaseController<GovernmentalClassification>
    {
        private readonly IBaseRepository<GovernmentalClassification> _repository;
        private readonly ILogger<GovernmentalClassificationsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IGovernmentalClassificationRepository _governmentalClassificationRepository;

        public GovernmentalClassificationsController(
            IBaseRepository<GovernmentalClassification> repository, 
            ILogger<GovernmentalClassificationsController> logger, 
            IConfiguration configuration, 
            IGovernmentalClassificationRepository governmentalClassificationRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _governmentalClassificationRepository = governmentalClassificationRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _governmentalClassificationRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
