using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Files;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class FilesController : BaseController<File>
    {
        private readonly IBaseRepository<File> _repository;
        private readonly ILogger<FilesController> _logger;
        private readonly IFileRepository _fileRepository;

        public FilesController(
            IBaseRepository<File> repository,
            ILogger<FilesController> logger,
            IFileRepository fileRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _fileRepository = fileRepository;
            BaseControllerOptions.GetAll = true;
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            var response = _fileRepository.GetAll2();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("async/create")]
        [DisableRequestSizeLimit, RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue, ValueLengthLimit = int.MaxValue)]
        public async Task<IActionResult> CreateAsync(FileCreateOrUpdateDto dto)
        {
            var response = await _fileRepository.CreateAsync(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("getByFileId")]
        public IActionResult GetByFileId(Guid fileId)
        {
            var response = _fileRepository.GetByFileId(fileId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(FileCreateOrUpdateDto dto)
        {
            var response = _fileRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-file")]
        public IActionResult DeleteFile(Guid fileId)
        {
            var response = _fileRepository.DeleteFile(fileId);
            return StatusCode(response.StatusCode, response);
        }
    }
}
