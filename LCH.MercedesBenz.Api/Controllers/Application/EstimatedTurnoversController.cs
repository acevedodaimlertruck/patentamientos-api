using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/EstimatedTurnovers")]
    public class EstimatedTurnoversController : BaseController<EstimatedTurnover>
    {
        private readonly IBaseRepository<EstimatedTurnover> _repository;
        private readonly ILogger<EstimatedTurnoversController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IEstimatedTurnoverRepository _estimatedTurnoverRepository;

        public EstimatedTurnoversController(
            IBaseRepository<EstimatedTurnover> repository, 
            ILogger<EstimatedTurnoversController> logger, 
            IConfiguration configuration, 
            IEstimatedTurnoverRepository estimatedTurnoverRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _estimatedTurnoverRepository = estimatedTurnoverRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _estimatedTurnoverRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
