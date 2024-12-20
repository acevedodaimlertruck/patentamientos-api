using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.BodyStyles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/BodyStyles")]
    public class BodyStylesController : BaseController<BodyStyle>
    {
        private readonly IBaseRepository<BodyStyle> _repository;
        private readonly ILogger<BodyStylesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IBodyStyleRepository _bodyStyleRepository;

        public BodyStylesController(
            IBaseRepository<BodyStyle> repository, 
            ILogger<BodyStylesController> logger, 
            IConfiguration configuration, 
            IBodyStyleRepository bodyStyleRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _bodyStyleRepository = bodyStyleRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _bodyStyleRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
