using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Universal;
using LCH.MercedesBenz.Api.Models.Universal.Sistemas;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Universal
{
    [Route("api/universal/[controller]")]
    public class SistemasController : BaseUniversalController<SistemaEntity>
    {
        private readonly IBaseUniversalRepository<SistemaEntity> _repository;
        private readonly ILogger<SistemasController> _logger;
        private readonly ISistemaRepository _sistemaRepository;

        public SistemasController(
            IBaseUniversalRepository<SistemaEntity> repository,
            ILogger<SistemasController> logger,
            ISistemaRepository sistemaRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _sistemaRepository = sistemaRepository;
        }

        /// <summary>
        /// Obtiene la lista de todos los sistemas.
        /// Opcionalmente se puede indicar que se ordenen los resultados
        /// por un campo determinado, el cual se especifica en el parámetro "by"
        /// y una dirección de ordenamiento (0: Ninguno (valor por defecto), 1: Ascendente, 2: Descendente)
        /// </summary>
        /// <param name="by">Nombre del campo de ordenamiento (Camel Case Sensitive)</param>
        /// <param name="direction">Dirección de ordenamiento</param>
        /// <returns></returns>
#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2(string? by = null, Direction direction = Direction.None)
        {
            var response = _sistemaRepository.GetAll(by, direction);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("by-user")]
        public IActionResult GetByCodUsuario(string codUsuario)
        {
            var response = _sistemaRepository.GetByCodUsuario(codUsuario);
            return StatusCode(response.StatusCode, response);
        }
    }
}
