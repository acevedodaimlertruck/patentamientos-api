using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/AperturesOne")]
    public class AperturesOneController : BaseController<ApertureOne>
    {
        private readonly IBaseRepository<ApertureOne> _repository;
        private readonly ILogger<AperturesOneController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IApertureOneRepository _apertureOneRepository;

        public AperturesOneController(
            IBaseRepository<ApertureOne> repository, 
            ILogger<AperturesOneController> logger, 
            IConfiguration configuration, 
            IApertureOneRepository apertureOneRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _apertureOneRepository = apertureOneRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _apertureOneRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
