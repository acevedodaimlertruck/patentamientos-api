using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{

    [Route("api/[controller]")]
    public class Cat_InternalVersionsController : BaseController<Cat_InternalVersion> 
    {
        private const string cat_InternalVersionListCacheKey = "cat_InternalVersionList";
        private readonly IBaseRepository<Cat_InternalVersion> _repository;
        private readonly ILogger<Cat_InternalVersionsController> _logger;
        private readonly ICat_InternalVersionRepository _cat_InternalVersionRepository;
        private IMemoryCache _cache;

        public Cat_InternalVersionsController(
            IBaseRepository<Cat_InternalVersion> repository,
            ILogger<Cat_InternalVersionsController> logger,
            ICat_InternalVersionRepository cat_InternalVersionRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _cat_InternalVersionRepository = cat_InternalVersionRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Catalog Internal Versions from cache.");
            if (_cache.TryGetValue(cat_InternalVersionListCacheKey, out BaseResponse<Cat_InternalVersionDto>? res))
            {
                _logger.Log(LogLevel.Information, "Catalog Internal Versions list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Catalog Internal Versions Versions list not found in cache. Fetching from database.");
                res = _cat_InternalVersionRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(cat_InternalVersionListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(Cat_InternalVersionDto dto)
        {
            var response = _cat_InternalVersionRepository.Create(dto);
            _cache.Remove(cat_InternalVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(Cat_InternalVersionDto dto)
        {
            var response = _cat_InternalVersionRepository.Update(dto);
            _cache.Remove(cat_InternalVersionListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-last-id")]
        public IActionResult GetLastId()
        {
            var response = _cat_InternalVersionRepository.GetLastId();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(_cat_InternalVersionRepository);
            return Delete(id);
        }
    }


}
