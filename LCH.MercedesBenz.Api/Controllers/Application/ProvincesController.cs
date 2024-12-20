using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Provinces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Provinces")]
    public class ProvincesController : BaseController<Province>
    {
        private readonly IBaseRepository<Province> _repository;
        private readonly ILogger<ProvincesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IProvinceRepository _provinceRepository;

        public ProvincesController(
            IBaseRepository<Province> repository, 
            ILogger<ProvincesController> logger, 
            IConfiguration configuration, 
            IProvinceRepository provinceRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _provinceRepository = provinceRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _provinceRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
