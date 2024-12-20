using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Brands")]
    public class BrandsController : BaseController<Brand>
    {
        private const string brandListCacheKey = "brandList";
        private readonly IBaseRepository<Brand> _repository;
        private readonly ILogger<BrandsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IBrandRepository _brandRepository;
        private IMemoryCache _cache;
        public BrandsController(
            IMemoryCache cache,
            IBaseRepository<Brand> repository, 
            ILogger<BrandsController> logger, 
            IConfiguration configuration, 
            IBrandRepository brandRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _brandRepository = brandRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Brands from cache.");
            if (_cache.TryGetValue(brandListCacheKey, out BaseResponse<BrandDto>? res))
            {
                _logger.Log(LogLevel.Information, "Brands list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Brands list not found in cache. Fetching from database.");
                res = _brandRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(brandListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(BrandDto dto)
        {
            var response = _brandRepository.Create(dto);
            _cache.Remove(brandListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(BrandDto dto)
        {
            var response = _brandRepository.Update(dto);
            _cache.Remove(brandListCacheKey);
            return StatusCode(response.StatusCode, response);
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _brandRepository.addJson(json);
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(brandListCacheKey);
            return Delete(id);
        }
    }
}
