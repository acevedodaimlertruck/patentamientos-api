using LCH.MercedesBenz.Api.Models.Application; 
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class PatentingVersionsController : BaseController<PatentingVersion>
    {
        private const string patentingVersionListCacheKey = "patentingVersionList";
        private readonly IBaseRepository<PatentingVersion> _repository;
        private readonly ILogger<PatentingVersionsController> _logger;
        private readonly IPatentingVersionRepository _patentingVersionRepository;
        private IMemoryCache _cache;

        public PatentingVersionsController(
            IBaseRepository<PatentingVersion> repository,
            ILogger<PatentingVersionsController> logger,
            IPatentingVersionRepository patentingVersionRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _patentingVersionRepository = patentingVersionRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Patenting Versions from cache.");
            if (_cache.TryGetValue(patentingVersionListCacheKey, out BaseResponse<PatentingVersionDto>? res))
            {
                _logger.Log(LogLevel.Information, "Patenting Versions list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Patenting Versions list not found in cache. Fetching from database.");
                res = _patentingVersionRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(patentingVersionListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(PatentingVersionDto dto)
        {
            var response = _patentingVersionRepository.Create(dto);
            _cache.Remove(patentingVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(PatentingVersionDto dto)
        {
            var response = _patentingVersionRepository.Update(dto);
            _cache.Remove(patentingVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-last-id")]
        public IActionResult GetLastId()
        {
            var response = _patentingVersionRepository.GetLastId();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(patentingVersionListCacheKey);
            return Delete(id);
        }
    }
}
