using LCH.MercedesBenz.Api.Models.Recolector.Formularios;
using LCH.MercedesBenz.Api.Services.Recolector.Formularios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LCH.MercedesBenz.Api.Models.Recolector;

namespace LCH.MercedesBenz.Api.Controllers.Recolector
{
    [Route("api/recolector/[controller]")]
    public class FormulariosController : BaseRecolectorController<FormularioEntity>
    {
        private readonly IBaseRecolectorRepository<FormularioEntity> _repository;
        private readonly ILogger<FormulariosController> _logger;
        private readonly IFormularioRepository _formularioRepository;
        private readonly IFormularioService _formularioService;

        public FormulariosController(
            IBaseRecolectorRepository<FormularioEntity> repository,
            ILogger<FormulariosController> logger,
            IFormularioRepository formularioRepository,
            IFormularioService formularioService) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _formularioRepository = formularioRepository;
            _formularioService = formularioService;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _formularioRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all3")]
        public IActionResult GetAll3()
        {
            var response = _formularioRepository.GetAll3();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("by-user")]
        public IActionResult GetByCodUsuario(string codUsuario)
        {
            var response = _formularioService.GetByCodUsuario(codUsuario);
            return StatusCode(response.StatusCode, response);
        }
    }
}
