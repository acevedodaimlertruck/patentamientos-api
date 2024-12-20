using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Owners;
using LCH.MercedesBenz.Api.Models.Application.Owners.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Owners")]
    public class OwnersController : BaseController<Owner>
    {
        private readonly IBaseRepository<Owner> _repository;
        private readonly ILogger<OwnersController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IOwnerRepository _ownerRepository;

        public OwnersController(
            IBaseRepository<Owner> repository, 
            ILogger<OwnersController> logger, 
            IConfiguration configuration, 
            IOwnerRepository ownerRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _ownerRepository = ownerRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _ownerRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(OwnerDto dto)
        {
            var response = _ownerRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(OwnerDto dto)
        {
            var response = _ownerRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
