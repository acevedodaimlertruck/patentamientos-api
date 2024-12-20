using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/LogisticClassifications")]
    public class LogisticClassificationsController : BaseController<LogisticClassification>
    {
        private readonly IBaseRepository<LogisticClassification> _repository;
        private readonly ILogger<LogisticClassificationsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ILogisticClassificationRepository _logisticClassificationRepository;

        public LogisticClassificationsController(
            IBaseRepository<LogisticClassification> repository, 
            ILogger<LogisticClassificationsController> logger, 
            IConfiguration configuration, 
            ILogisticClassificationRepository logisticClassificationRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _logisticClassificationRepository = logisticClassificationRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _logisticClassificationRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
