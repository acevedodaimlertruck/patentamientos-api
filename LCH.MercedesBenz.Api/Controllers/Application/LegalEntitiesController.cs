using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.LegalEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/LegalEntities")]
    public class LegalEntitiesController : BaseController<LegalEntity>
    {
        private readonly IBaseRepository<LegalEntity> _repository;
        private readonly ILogger<LegalEntitiesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ILegalEntityRepository _legalEntityRepository;

        public LegalEntitiesController(
            IBaseRepository<LegalEntity> repository, 
            ILogger<LegalEntitiesController> logger, 
            IConfiguration configuration, 
            ILegalEntityRepository legalEntityRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _legalEntityRepository = legalEntityRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _legalEntityRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
