using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class InternalVersionSegmentationsController : BaseController<InternalVersionSegmentation>
    {
        private const string InternalVersionSegmentationListCacheKey = "InternalVersionSegmentationList";
        private readonly IBaseRepository<InternalVersionSegmentation> _repository;
        private readonly ILogger<InternalVersionSegmentationsController> _logger;
        private readonly IInternalVersionSegmentationRepository _InternalVersionSegmentationRepository;
        private IMemoryCache _cache;

        public InternalVersionSegmentationsController(
            IBaseRepository<InternalVersionSegmentation> repository,
            ILogger<InternalVersionSegmentationsController> logger,
            IInternalVersionSegmentationRepository InternalVersionSegmentationRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _InternalVersionSegmentationRepository = InternalVersionSegmentationRepository;
            _cache = cache;
            BaseControllerOptions.GetAll = true;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all2")]
        public IActionResult GetAll2()
        {
            //// Iniciar el cronómetro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Internal Version Segmentations from cache.");
            if (_cache.TryGetValue(InternalVersionSegmentationListCacheKey, out BaseResponse<InternalVersionSegmentationDto>? res))
            {
                _logger.Log(LogLevel.Information, "Internal Version Segmentations list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Internal Version Segmentations list not found in cache. Fetching from database.");
                res = _InternalVersionSegmentationRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(InternalVersionSegmentationListCacheKey, res, cacheEntryOptions);
            }
            stopwatch.Stop();
            long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Duración de la llamada GetAll2: {elapsedTimeMs} ms");
            return StatusCode(res.StatusCode, res);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(InternalVersionSegmentationDto dto)
        {
            var response = _InternalVersionSegmentationRepository.Create(dto);
            _cache.Remove(InternalVersionSegmentationListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create2")]
        public IActionResult Create2(InternalVersionSegmentationCreateDto dto)
        {
            var response = _InternalVersionSegmentationRepository.Create2(dto);
            _cache.Remove(InternalVersionSegmentationListCacheKey);
            return StatusCode(response.StatusCode, response);
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update2(InternalVersionSegmentationUpdateDto dto)
        {
            var response = _InternalVersionSegmentationRepository.Update(dto);
            _cache.Remove(InternalVersionSegmentationListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(InternalVersionSegmentationListCacheKey);
            return Delete(id);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-catalogs")]
        public IActionResult GetCatalogs()
        {
            var response = _InternalVersionSegmentationRepository.GetCatalogs();
            return StatusCode(response.StatusCode, response);
        }
    }
}
