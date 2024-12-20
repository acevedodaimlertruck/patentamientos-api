using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/VehicleTypes")]
    public class VehicleTypesController : BaseController<VehicleType>
    {
        private readonly IBaseRepository<VehicleType> _repository;
        private readonly ILogger<VehicleTypesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IVehicleTypeRepository _vehicleTypeRepository;

        public VehicleTypesController(
            IBaseRepository<VehicleType> repository, 
            ILogger<VehicleTypesController> logger, 
            IConfiguration configuration, 
            IVehicleTypeRepository vehicleTypeRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _vehicleTypeRepository = vehicleTypeRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _vehicleTypeRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(VehicleTypeDto dto)
        {
            var response = _vehicleTypeRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(VehicleTypeDto dto)
        {
            var response = _vehicleTypeRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
