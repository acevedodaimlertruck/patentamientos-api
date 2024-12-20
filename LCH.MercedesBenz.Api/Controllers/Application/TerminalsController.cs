using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Terminals")]
    public class TerminalsController : BaseController<Terminal>
    {
        private const string terminalListCacheKey = "terminalList";
        private readonly IBaseRepository<Terminal> _repository;
        private readonly ILogger<TerminalsController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ITerminalRepository _terminalRepository;
        private IMemoryCache _cache;

        public TerminalsController(
            IBaseRepository<Terminal> repository, 
            ILogger<TerminalsController> logger, 
            IConfiguration configuration, 
            ITerminalRepository terminalRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _terminalRepository = terminalRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Terminals from cache.");
            if (_cache.TryGetValue(terminalListCacheKey, out BaseResponse<TerminalDto>? res))
            {
                _logger.Log(LogLevel.Information, "Terminals list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Terminals list not found in cache. Fetching from database.");
                res = _terminalRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(terminalListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(TerminalDto dto)
        {
            var response = _terminalRepository.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(TerminalDto dto)
        {
            var response = _terminalRepository.Update(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("addJson")]
        public IActionResult addJson(dynamic json)
        {
            var response = _terminalRepository.addJson(json);
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(terminalListCacheKey);
            return Delete(id);
        }
    }
}
