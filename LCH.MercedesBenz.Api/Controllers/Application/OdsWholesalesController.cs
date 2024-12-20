using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/OdsWholesales")]
    public class OdsWholesalesController : BaseController<OdsWholesale>
    {
        private readonly IBaseRepository<OdsWholesale> _repository;
        private readonly ILogger<OdsWholesalesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IOdsWholesaleRepository _odsWholesaleRepository;

        public OdsWholesalesController(
            IBaseRepository<OdsWholesale> repository, 
            ILogger<OdsWholesalesController> logger, 
            IConfiguration configuration, 
            IOdsWholesaleRepository odsWholesaleRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _odsWholesaleRepository = odsWholesaleRepository;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _odsWholesaleRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-by-file-id")]
        public IActionResult GetByFileId(Guid fileId)
        {
            var response = _odsWholesaleRepository.GetByFileId(fileId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("save-wholesale")]
        public IActionResult SaveWholesale(OdsWholesaleDto odsWholesaleDto)
        {
            var response = _odsWholesaleRepository.SaveWholesale(odsWholesaleDto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(OdsWholesaleDto dto)
        {
            var response = _odsWholesaleRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(OdsWholesaleDto dto)
        {
            var response = _odsWholesaleRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
