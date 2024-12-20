using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Categories;
using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/[controller]")]
    public class CategoriesController : BaseController<Category>
    {
        private const string categoryListCacheKey = "categoryList";
        private readonly IBaseRepository<Category> _repository;
        private readonly ILogger<CategoriesController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private IMemoryCache _cache;

        public CategoriesController(
            IBaseRepository<Category> repository,
            ILogger<CategoriesController> logger,
            ICategoryRepository categoryRepository,
            IMemoryCache cache) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _categoryRepository = categoryRepository;
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
            _logger.Log(LogLevel.Information, "Trying to fetch the list of Categories from cache.");
            if (_cache.TryGetValue(categoryListCacheKey, out BaseResponse<CategoryDto>? res))
            {
                _logger.Log(LogLevel.Information, "Categories list found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Categories list not found in cache. Fetching from database.");
                res = _categoryRepository.GetAll2();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(categoryListCacheKey, res, cacheEntryOptions);
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
        public IActionResult Create(CategoryDto dto)
        {
            var response = _categoryRepository.Create(dto);
            _cache.Remove(categoryListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(CategoryDto dto)
        {
            var response = _categoryRepository.Update(dto);
            _cache.Remove(categoryListCacheKey);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpDelete, Route("delete-cache/{id}")]
        public IActionResult deleteCache(Guid id)
        {
            _cache.Remove(categoryListCacheKey);
            return Delete(id);
        }
    }
}
