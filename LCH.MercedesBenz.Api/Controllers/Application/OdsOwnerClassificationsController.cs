using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications;
using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/OdsOwnerClassifications")]
    public class OdsOwnerClassificationsController : BaseController<OdsOwnerClassification>
    {
        private readonly IBaseRepository<OdsOwnerClassification> _repository;
        private readonly ILogger<OdsOwnerClassificationsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IOdsOwnerClassificationRepository _odsOwnerClassificationRepository;

        public OdsOwnerClassificationsController(
            IBaseRepository<OdsOwnerClassification> repository, 
            ILogger<OdsOwnerClassificationsController> logger, 
            IConfiguration configuration, 
            IOdsOwnerClassificationRepository odsOwnerClassificationRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _odsOwnerClassificationRepository = odsOwnerClassificationRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _odsOwnerClassificationRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(OdsOwnerClassificationDto dto)
        {
            var response = _odsOwnerClassificationRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(OdsOwnerClassificationDto dto)
        {
            var response = _odsOwnerClassificationRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
