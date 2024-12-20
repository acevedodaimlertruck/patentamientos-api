using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Tractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Tractions")]
    public class TractionsController : BaseController<Traction>
    {
        private readonly IBaseRepository<Traction> _repository;
        private readonly ILogger<TractionsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ITractionRepository _tractionRepository;

        public TractionsController(
            IBaseRepository<Traction> repository, 
            ILogger<TractionsController> logger, 
            IConfiguration configuration, 
            ITractionRepository tractionRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _tractionRepository = tractionRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _tractionRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
