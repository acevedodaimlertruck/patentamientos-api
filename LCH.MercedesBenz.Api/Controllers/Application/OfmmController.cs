using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.OFMM;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class OfmmsController : BaseController<Ofmm>
    {
        private const string ofmmListCacheKey = "ofmmList";
        private readonly IBaseRepository<Ofmm> _repository;
        private readonly ILogger<OfmmsController> _logger;
        private readonly IOfmmRepository _ofmmRepository;
        private IMemoryCache _cache;
        public OfmmsController(
            IMemoryCache cache,
            IBaseRepository<Ofmm> repository,
            ILogger<OfmmsController> logger,
            IOfmmRepository ofmmRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _ofmmRepository = ofmmRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of ofmm from cache.");
            if (_cache.TryGetValue(ofmmListCacheKey, out BaseResponse<OfmmDto>? res))
            {
                _logger.Log(LogLevel.Information, "Ofmm list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "ofmm list not found in cache. Fetching from database.");
                res = _ofmmRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(ofmmListCacheKey, res, cacheEntryOptions);
            }
            stopwatch.Stop();
            long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Duración de la llamada GetAll2: {elapsedTimeMs} ms");
            return StatusCode(res!.StatusCode, res);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(OfmmDto dto)
        {
            var response = _ofmmRepository.Create(dto);
            _cache.Remove(ofmmListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create-multiple-ofmms")]
        public IActionResult CreateMultipleOfmms([FromBody] OfmmDto[] dtos)
        {
            if (dtos == null || dtos.Length == 0)
            {
                return BadRequest("La lista de Ofmms no puede estar vacía");
            }
            var response = _ofmmRepository.CreateMultipleOfmms(dtos);
            _cache.Remove(ofmmListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(OfmmDto dto)
        {
            var response = _ofmmRepository.Update(dto);
            _cache.Remove(ofmmListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _ofmmRepository.addJson(json);
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(ofmmListCacheKey);
            return Delete(id);
        }
    }
}
