using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.EventFiles;
using LCH.MercedesBenz.Api.Models.Application.EventFiles.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class EventFilesController : BaseController<EventFile>
    {
        private readonly IBaseRepository<EventFile> _repository;
        private readonly ILogger<EventFilesController> _logger;
        private readonly IEventFileRepository _eventFileRepository;

        public EventFilesController(
            IBaseRepository<EventFile> repository,
            ILogger<EventFilesController> logger,
            IEventFileRepository eventFileRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _eventFileRepository = eventFileRepository;
            BaseControllerOptions.GetAll = true;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(EventFileCreateOrUpdateDto dto)
        {
            var response = _eventFileRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(EventFileCreateOrUpdateDto dto)
        {
            var response = _eventFileRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
