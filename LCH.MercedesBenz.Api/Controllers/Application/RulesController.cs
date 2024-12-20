using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Rules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Rules")]
    public class RulesController : BaseController<Rule>
    {
        private readonly IBaseRepository<Rule> _repository;
        private readonly ILogger<RulesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IRuleRepository _ruleRepository;

        public RulesController(
            IBaseRepository<Rule> repository, 
            ILogger<RulesController> logger, 
            IConfiguration configuration, 
            IRuleRepository ruleRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _ruleRepository = ruleRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _ruleRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
