using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/CarModels")]
    public class CarModelsController : BaseController<CarModel>
    {
        private const string carModelsListCacheKey = "carModelsList";
        private readonly IBaseRepository<CarModel> _repository;
        private readonly ILogger<CarModelsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ICarModelRepository _carModelRepository;
        private IMemoryCache _cache;


        public CarModelsController(
            IMemoryCache cache,
            IBaseRepository<CarModel> repository, 
            ILogger<CarModelsController> logger, 
            IConfiguration configuration, 
            ICarModelRepository carModelRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _carModelRepository = carModelRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of CarModels from cache.");
            if (_cache.TryGetValue(carModelsListCacheKey, out BaseResponse<CarModelDto>? res))
            {
                _logger.Log(LogLevel.Information, "CarModels list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "CarModels list not found in cache. Fetching from database.");
                res = _carModelRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(carModelsListCacheKey, res, cacheEntryOptions);
            }
            stopwatch.Stop();
            long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Duración de la llamada GetAll2: {elapsedTimeMs} ms");
            return StatusCode(res!.StatusCode, res);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("get-no-assigned")]
        public IActionResult GetNoAssigned()
        {
            var response = _carModelRepository.GetNoAssigned();
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(CarModelDto dto)
        {
            var response = _carModelRepository.Create(dto);
            _cache.Remove(carModelsListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(CarModelDto dto)
        {
            var response = _carModelRepository.Update(dto);
            _cache.Remove(carModelsListCacheKey);
            return StatusCode(response.StatusCode, response);
        }


#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _carModelRepository.addJson(json);
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(carModelsListCacheKey);
            return Delete(id);
        }
    }
}
