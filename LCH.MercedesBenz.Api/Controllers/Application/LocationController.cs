using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Locations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Locations")]
    public class LocationsController : BaseController<Location>
    {
        private readonly IBaseRepository<Location> _repository;
        private readonly ILogger<LocationsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ILocationRepository _locationRepository;

        public LocationsController(
            IBaseRepository<Location> repository, 
            ILogger<LocationsController> logger, 
            IConfiguration configuration, 
            ILocationRepository locationRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _locationRepository = locationRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _locationRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }
    }
}
