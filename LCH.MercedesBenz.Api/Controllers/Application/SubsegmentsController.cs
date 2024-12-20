using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Subsegments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Subsegments")]
    public class SubsegmentsController : BaseController<Subsegment>
    {
        private readonly IBaseRepository<Subsegment> _repository;
        private readonly ILogger<SubsegmentsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISubsegmentRepository _subsegmentRepository;

        public SubsegmentsController(
            IBaseRepository<Subsegment> repository, 
            ILogger<SubsegmentsController> logger, 
            IConfiguration configuration, 
            ISubsegmentRepository subsegmentRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _subsegmentRepository = subsegmentRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _subsegmentRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
