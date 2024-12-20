using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/SubgovernmentalClassifications")]
    public class SubgovernmentalClassificationsController : BaseController<SubgovernmentalClassification>
    {
        private readonly IBaseRepository<SubgovernmentalClassification> _repository;
        private readonly ILogger<SubgovernmentalClassificationsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISubgovernmentalClassificationRepository _subgovernmentalClassificationRepository;

        public SubgovernmentalClassificationsController(
            IBaseRepository<SubgovernmentalClassification> repository, 
            ILogger<SubgovernmentalClassificationsController> logger, 
            IConfiguration configuration, 
            ISubgovernmentalClassificationRepository subgovernmentalClassificationRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _subgovernmentalClassificationRepository = subgovernmentalClassificationRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _subgovernmentalClassificationRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
