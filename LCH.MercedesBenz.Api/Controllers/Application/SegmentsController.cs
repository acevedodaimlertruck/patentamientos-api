using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Segments;
using LCH.MercedesBenz.Api.Models.Application.Segments.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class SegmentsController : BaseController<Segment>
    {
        private const string segmentListCacheKey = "segmentList";
        private readonly IBaseRepository<Segment> _repository;
        private readonly ILogger<SegmentsController> _logger;
        private readonly ISegmentRepository _segmentRepository;
        private IMemoryCache _cache;

        public SegmentsController(
            IBaseRepository<Segment> repository,
            ILogger<SegmentsController> logger,
            ISegmentRepository segmentRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _segmentRepository = segmentRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Segments from cache.");
            if (_cache.TryGetValue(segmentListCacheKey, out BaseResponse<SegmentDto>? res))
            {
                _logger.Log(LogLevel.Information, "Segments list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Segments list not found in cache. Fetching from database.");
                res = _segmentRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(segmentListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(SegmentDto dto)
        {
            var response = _segmentRepository.Create(dto);
            _cache.Remove(segmentListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(SegmentDto dto)
        {
            var response = _segmentRepository.Update(dto);
            _cache.Remove(segmentListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(segmentListCacheKey);
            return Delete(id);
        }
    }
}
