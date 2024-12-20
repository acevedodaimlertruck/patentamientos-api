using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.FileTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class FileTypesController : BaseController<FileType>
    {
        private readonly IBaseRepository<FileType> _repository;
        private readonly ILogger<FileTypesController> _logger;
        private readonly IFileTypeRepository _fileTypeRepository;

        public FileTypesController(
            IBaseRepository<FileType> repository,
            ILogger<FileTypesController> logger,
            IFileTypeRepository fileTypeRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _fileTypeRepository = fileTypeRepository;
            BaseControllerOptions.GetAll = true;
        }

    }
}
