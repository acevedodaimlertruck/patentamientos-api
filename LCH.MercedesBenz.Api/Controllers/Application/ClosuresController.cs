using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Closures;
using LCH.MercedesBenz.Api.Models.Application.Closures.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class ClosuresController : BaseController<Closure>
    {
        private readonly IBaseRepository<Closure> _repository;
        private readonly ILogger<ClosuresController> _logger;
        private readonly IClosureRepository _closureRepository;

        public ClosuresController(
            IBaseRepository<Closure> repository,
            ILogger<ClosuresController> logger,
            IClosureRepository closureRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _closureRepository = closureRepository;
            BaseControllerOptions.GetAll = true;
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _closureRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(ClosureDto dto)
        {
            var response = _closureRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _closureRepository.addJson(json);
            return Ok(response);
        }
    }
}
