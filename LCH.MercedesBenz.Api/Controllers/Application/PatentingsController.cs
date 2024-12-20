using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class PatentingsController : BaseController<Patenting>
    {
        private readonly IBaseRepository<Patenting> _repository;
        private readonly ILogger<PatentingsController> _logger;
        private readonly IPatentingRepository _patentingRepository;

        public PatentingsController(
            IBaseRepository<Patenting> repository,
            ILogger<PatentingsController> logger,
            IPatentingRepository patentingRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _patentingRepository = patentingRepository;
            BaseControllerOptions.GetAll = true;
        }



#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _patentingRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("patenting-by-fileId")]
        public IActionResult GetPatentingByFileId(Guid fileId)
        {
            var response = _patentingRepository.GetPatentingByFileId(fileId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-all-patentings")]
        public IActionResult GetAllPatentings()
        {
            var response = _patentingRepository.GetAllPatentings();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-patentings-filtered")]
        public IActionResult GetPatentingsFiltered(string? dateFrom, string? dateTo, bool? lastDischarge, string? errorType, string? fileId)
        {
            var response = _patentingRepository.GetPatentingsFiltered(dateFrom, dateTo, lastDischarge, errorType, fileId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("rules-by-patentingId")]
        public IActionResult GetRulesPatentingById(Guid patentingId)
        {
            var response = _patentingRepository.GetRulesPatentingById(patentingId);
            return StatusCode(response.StatusCode, response);
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("process-by-fileId")]
        public IActionResult ProcessByFileId(Guid fileId, Guid fileTypeId, Guid? wsID)
        {
            var response = _patentingRepository.ProcessByFileId(fileId, fileTypeId, wsID);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("save-by-patentingId")]
        public IActionResult SaveByPatentingId(Guid patentingId)
        {
            var response = _patentingRepository.SaveByPatentingId(patentingId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("patenting-by-id")]
        public IActionResult GetPatentingById(Guid patentingId)
        {
            var response = _patentingRepository.GetPatentingById(patentingId);
            return StatusCode(response.StatusCode, response);
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("save-patenting")]
        public IActionResult SavePatenting(PatentingUpdateDto patentingDto)
        {
            var response = _patentingRepository.SavePatenting(patentingDto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("fix-error-ofmm")]
        public IActionResult FixErrorOfmm(string ofmm)
        {
            var response = _patentingRepository.FixErrorOfmm(ofmm);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-last-patenting")]
        public IActionResult GetLastFilePatenting()
        {
            var response = _patentingRepository.GetLastFilePatenting();
            return StatusCode(response.StatusCode, response);
        }
    }
}
