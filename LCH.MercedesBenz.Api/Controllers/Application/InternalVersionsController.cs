using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class InternalVersionsController : BaseController<InternalVersion>
    {
        private const string internalVersionListCacheKey = "internalVersionList";
        private readonly IBaseRepository<InternalVersion> _repository;
        private readonly ILogger<InternalVersionsController> _logger;
        private readonly IInternalVersionRepository _internalVersionRepository;
        private IMemoryCache _cache;

        public InternalVersionsController(
            IBaseRepository<InternalVersion> repository,
            ILogger<InternalVersionsController> logger,
            IInternalVersionRepository internalVersionRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _internalVersionRepository = internalVersionRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Internal Versions from cache.");
            if (_cache.TryGetValue(internalVersionListCacheKey, out BaseResponse<InternalVersionDto>? res))
            {
                _logger.Log(LogLevel.Information, "Internal Versions list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Internal Versions list not found in cache. Fetching from database.");
                res = _internalVersionRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(internalVersionListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(InternalVersionDto dto)
        {
            var response = _internalVersionRepository.Create(dto);
            _cache.Remove(internalVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(InternalVersionDto dto)
        {
            var response = _internalVersionRepository.Update(dto);
            _cache.Remove(internalVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-last-id")]
        public IActionResult GetLastId()
        {
            var response = _internalVersionRepository.GetLastId();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(internalVersionListCacheKey);
            return Delete(id);
        }
    }
}
