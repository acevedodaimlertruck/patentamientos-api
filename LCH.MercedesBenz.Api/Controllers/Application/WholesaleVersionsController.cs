using LCH.MercedesBenz.Api.Models.Application; 
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class WholesaleVersionsController : BaseController<WholesaleVersion>
    {
        private const string wholesaleVersionListCacheKey = "wholesaleVersionList";
        private readonly IBaseRepository<WholesaleVersion> _repository;
        private readonly ILogger<WholesaleVersionsController> _logger;
        private readonly IWholesaleVersionRepository _wholesaleVersionRepository;
        private IMemoryCache _cache;

        public WholesaleVersionsController(
            IBaseRepository<WholesaleVersion> repository,
            ILogger<WholesaleVersionsController> logger,
            IWholesaleVersionRepository wholesaleVersionRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _wholesaleVersionRepository = wholesaleVersionRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Wholesale Versions from cache.");
            if (_cache.TryGetValue(wholesaleVersionListCacheKey, out BaseResponse<WholesaleVersionDto>? res))
            {
                _logger.Log(LogLevel.Information, "Wholesale Versions list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Wholesale Versions list not found in cache. Fetching from database.");
                res = _wholesaleVersionRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(wholesaleVersionListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(WholesaleVersionDto dto)
        {
            var response = _wholesaleVersionRepository.Create(dto);
            _cache.Remove(wholesaleVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(WholesaleVersionDto dto)
        {
            var response = _wholesaleVersionRepository.Update(dto);
            _cache.Remove(wholesaleVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-last-id")]
        public IActionResult GetLastId()
        {
            var response = _wholesaleVersionRepository.GetLastId();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(wholesaleVersionListCacheKey);
            return Delete(id);
        }
    }
}
