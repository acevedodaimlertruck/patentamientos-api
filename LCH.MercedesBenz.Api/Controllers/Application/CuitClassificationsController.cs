using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.CuitClassifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/CuitClassifications")]
    public class CuitClassificationsController : BaseController<CuitClassification>
    {
        private readonly IBaseRepository<CuitClassification> _repository;
        private readonly ILogger<CuitClassificationsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ICuitClassificationRepository _cuitClassificationRepository;

        public CuitClassificationsController(
            IBaseRepository<CuitClassification> repository, 
            ILogger<CuitClassificationsController> logger, 
            IConfiguration configuration, 
            ICuitClassificationRepository cuitClassificationRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _cuitClassificationRepository = cuitClassificationRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _cuitClassificationRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
