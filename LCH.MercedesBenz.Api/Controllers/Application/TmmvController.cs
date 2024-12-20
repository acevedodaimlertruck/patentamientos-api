using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.TMMVS.Dtos;
using LCH.MercedesBenz.Api.Models.Application.TMMVS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class TMMVsController : BaseController<TMMV>
    {
        private const string tmmvsListCacheKey = "tmmvsList";
        private readonly IBaseRepository<TMMV> _repository;
        private readonly ILogger<TMMVsController> _logger;
        private readonly ITMMVRepository _tmmvRepository;
        private IMemoryCache _cache;

        public TMMVsController(
            IBaseRepository<TMMV> repository,
            ILogger<TMMVsController> logger,
            ITMMVRepository tmmvRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _tmmvRepository = tmmvRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of TMMVS from cache.");
            if (_cache.TryGetValue(tmmvsListCacheKey, out BaseResponse<TMMVDto>? res))
            {
                _logger.Log(LogLevel.Information, "TMMVS list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "TMMVS list not found in cache. Fetching from database.");
                res = _tmmvRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(tmmvsListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(TMMVDto dto)
        {
            var response = _tmmvRepository.Create(dto);
            _cache.Remove(tmmvsListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(TMMVDto dto)
        {
            var response = _tmmvRepository.Update(dto);
            _cache.Remove(tmmvsListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-ver-pats")]
        public IActionResult GetVerPats(Guid carModelId)
        {
            var response = _tmmvRepository.GetVerPats(carModelId);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _tmmvRepository.addJson(json);
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(tmmvsListCacheKey);
            return Delete(id);
        }
    }
}
