using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RegSecs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/RegSecs")]
    public class RegSecsController : BaseController<RegSec>
    {
        private readonly IBaseRepository<RegSec> _repository;
        private readonly ILogger<RegSecsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IRegSecRepository _regSecRepository;

        public RegSecsController(
            IBaseRepository<RegSec> repository, 
            ILogger<RegSecsController> logger, 
            IConfiguration configuration, 
            IRegSecRepository regSecRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _regSecRepository = regSecRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _regSecRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("upload-file")]
        public IActionResult UploadFile(RegSecUpload formUpload)
        {
            var response = _regSecRepository.UploadFile(formUpload);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(RegSecDto dto)
        {
            var response = _regSecRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(RegSecDto dto)
        {
            var response = _regSecRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
