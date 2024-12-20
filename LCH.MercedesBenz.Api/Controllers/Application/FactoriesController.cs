using Azure;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Factories;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Factories")]
    public class FactoriesController : BaseController<Factory>
    {
        private const string factoriesListCacheKey = "factoriesList";
        private readonly IBaseRepository<Factory> _repository;
        private readonly ILogger<FactoriesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IFactoryRepository _factoryRepository;
        private IMemoryCache _cache;

        public FactoriesController(
            IMemoryCache cache,
            IBaseRepository<Factory> repository, 
            ILogger<FactoriesController> logger, 
            IConfiguration configuration, 
            IFactoryRepository factoryRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _factoryRepository = factoryRepository;
            BaseControllerOptions.GetAll = true;
            _cache = cache;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of factories from cache.");
            if (_cache.TryGetValue(factoriesListCacheKey, out BaseResponse<FactoryDto>? res))
            {
                _logger.Log(LogLevel.Information, "Factories list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "factories list not found in cache. Fetching from database.");
                res = _factoryRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(factoriesListCacheKey, res, cacheEntryOptions);
            }
            stopwatch.Stop();
            long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Duración de la llamada GetAll2: {elapsedTimeMs} ms");
            return StatusCode(res!.StatusCode, res);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _factoryRepository.addJson(json);
            return response;
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(FactoryDto dto)
        {
            var response = _factoryRepository.Create(dto);
            _cache.Remove(factoriesListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(FactoryDto dto)
        {
            var response = _factoryRepository.Update(dto);
            _cache.Remove(factoriesListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJsonProv")]
        public IActionResult addJsonProv(dynamic json)
        {
            var response = _factoryRepository.addJsonProv(json);
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(factoriesListCacheKey);
            return Delete(id);
        }
    }
}
