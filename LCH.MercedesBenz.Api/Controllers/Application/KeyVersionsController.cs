using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class KeyVersionsController : BaseController<KeyVersion>
    {
        private const string keyVersionListCacheKey = "keyVersionList";
        private readonly IBaseRepository<KeyVersion> _repository;
        private readonly ILogger<KeyVersionsController> _logger;
        private readonly IKeyVersionRepository _keyVersionRepository;
        private IMemoryCache _cache;

        public KeyVersionsController(
            IBaseRepository<KeyVersion> repository,
            ILogger<KeyVersionsController> logger,
            IKeyVersionRepository keyVersionRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _keyVersionRepository = keyVersionRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Key Versions from cache.");
            if (_cache.TryGetValue(keyVersionListCacheKey, out BaseResponse<KeyVersionDto>? res))
            {
                _logger.Log(LogLevel.Information, "Key Versions list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Key Versions list not found in cache. Fetching from database.");
                res = _keyVersionRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(keyVersionListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(KeyVersionDto dto)
        {
            var response = _keyVersionRepository.Create(dto);
            _cache.Remove(keyVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(KeyVersionDto dto)
        {
            var response = _keyVersionRepository.Update(dto);
            _cache.Remove(keyVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(keyVersionListCacheKey);
            return Delete(id);
        }
    }
}
