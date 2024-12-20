using LCH.MercedesBenz.Api.Models.Recolector;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Recolector
{
    [Route("api/recolector/[controller]")]
    public class VersionesController : BaseRecolectorController<VersionEntity>
    {
        private readonly IBaseRecolectorRepository<VersionEntity> _repository;
        private readonly ILogger<VersionesController> _logger;
        private readonly IVersionRepository _versionRepository;

        public VersionesController(
            IBaseRecolectorRepository<VersionEntity> repository,
            ILogger<VersionesController> logger,
            IVersionRepository versionRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _versionRepository = versionRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _versionRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("by-form")]
        public IActionResult GetByCodFormulario(string codFormulario)
        {
            var response = _versionRepository.GetByCodFormulario(codFormulario);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("by-form-version")]
        public IActionResult GetByCodFormularioAndCodVersion(string codFormulario, string codVersion)
        {
            var response = _versionRepository.GetByCodFormularioAndCodVersion(codFormulario, codVersion);
            return StatusCode(response.StatusCode, response);
        }
    }
}
