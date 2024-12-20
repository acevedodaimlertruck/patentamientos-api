using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class SegmentationPlatesController : BaseController<SegmentationPlate>
    {
        private readonly IBaseRepository<SegmentationPlate> _repository;
        private readonly ILogger<SegmentationPlatesController> _logger;
        private readonly ISegmentationPlateRepository _segmentationPlateRepository;

        public SegmentationPlatesController(
            IBaseRepository<SegmentationPlate> repository,
            ILogger<SegmentationPlatesController> logger,
            ISegmentationPlateRepository segmentationPlateRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _segmentationPlateRepository = segmentationPlateRepository;
            BaseControllerOptions.GetAll = true;
        }



#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _segmentationPlateRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("process-segmentations")]
        public IActionResult ProcessSegmentations(string? dateFrom, string? dateTo, Guid? fileId, Guid? patentaId)
        {
            var response = _segmentationPlateRepository.ProcessSegmentations(dateFrom, dateTo, fileId, patentaId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-by-category")]
        public IActionResult GetSegmentationsByCategory(string category)
        {
            var response = _segmentationPlateRepository.GetSegmentationsByCategory(category);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-by-fileId")]
        public IActionResult GetSegmentationsByFileId(Guid fileId)
        {
            var response = _segmentationPlateRepository.GetSegmentationsByFileId(fileId);
            return StatusCode(response.StatusCode, response);
        }
    }
}
