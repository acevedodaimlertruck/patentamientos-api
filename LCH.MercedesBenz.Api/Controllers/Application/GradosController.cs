using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Grados;
using LCH.MercedesBenz.Api.Models.Application.Grados.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Grados")]
    public class GradosController : BaseController<Grado>
    {
        private readonly IBaseRepository<Grado> _repository;
        private readonly ILogger<GradosController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IGradoRepository _gradoRepository;

        public GradosController(
            IBaseRepository<Grado> repository, 
            ILogger<GradosController> logger, 
            IConfiguration configuration, 
            IGradoRepository gradoRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _gradoRepository = gradoRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _gradoRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(GradoDto dto)
        {
            var response = _gradoRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(GradoDto dto)
        {
            var response = _gradoRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
