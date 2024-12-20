using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Bodyworks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Bodyworks")]
    public class BodyworksController : BaseController<Bodywork>
    {
        private readonly IBaseRepository<Bodywork> _repository;
        private readonly ILogger<BodyworksController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IBodyworkRepository _bodyworkRepository;

        public BodyworksController(
            IBaseRepository<Bodywork> repository, 
            ILogger<BodyworksController> logger, 
            IConfiguration configuration, 
            IBodyworkRepository bodyworkRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _bodyworkRepository = bodyworkRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _bodyworkRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
