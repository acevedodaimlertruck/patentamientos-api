using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Universal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Universal
{
    //[Authorize]
    [Authorize("LchIdentityServer4Policy", AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class BaseUniversalController<T> : ControllerBase where T : BaseUniversalEntity, new()
    {
        public readonly IBaseUniversalRepository<T> BaseUniversalRepository;
        public readonly ILogger<BaseUniversalController<T>> Logger;
        public readonly BaseUniversalControllerOptions BaseUniversalControllerOptions;
        const string bc403 = "BC403: Acción prohibida por las opciones del controlador base. Configure la opción correspondiente en su controlador.";

        protected BaseUniversalController(
            IBaseUniversalRepository<T> baseUniversalRepository,
            ILogger<BaseUniversalController<T>> logger,
            BaseUniversalControllerOptions? baseControllerOptions = null)
        {
            BaseUniversalRepository = baseUniversalRepository;
            Logger = logger;
            if (baseControllerOptions == null)
            {
                BaseUniversalControllerOptions = new BaseUniversalControllerOptions();
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("all")]
        public IActionResult GetAll()
        {
            BaseResponse<T>? response;
            try
            {
                if (!BaseUniversalControllerOptions.GetAll)
                {
                    response = new BaseResponse<T>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseUniversalRepository.GetAll();
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<T>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("async/all")]
        public async Task<IActionResult> GetAllAsync()
        {
            BaseResponse<T>? response;
            try
            {
                if (!BaseUniversalControllerOptions.GetAllAsync)
                {
                    response = new BaseResponse<T>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseUniversalRepository.GetAllAsync();
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<T>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("count")]
        public IActionResult Count()
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseUniversalControllerOptions.Count)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseUniversalRepository.Count();
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("async/count")]
        public async Task<IActionResult> CountAsync()
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseUniversalControllerOptions.CountAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseUniversalRepository.CountAsync();
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("add")]
        public IActionResult Add([FromBody] T value)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseUniversalControllerOptions.Add)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseUniversalRepository.InsertAndSave(value);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("async/add")]
        public async Task<IActionResult> AddAsync([FromBody] T value)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseUniversalControllerOptions.AddAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseUniversalRepository.InsertAndSaveAsync(value);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("edit")]
        public IActionResult Edit([FromBody] T value)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseUniversalControllerOptions.Edit)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseUniversalRepository.UpdateAndSave(value);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("async/edit")]
        public async Task<IActionResult> EditAsync([FromBody] T value)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseUniversalControllerOptions.EditAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseUniversalRepository.UpdateAndSaveAsync(value);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }

    public class BaseUniversalControllerOptions
    {
        public bool GetAll { get; set; } = false;
        public bool GetAllAsync { get; set; } = false;
        public bool GetById { get; set; } = false;
        public bool GetByIdAsync { get; set; } = false;
        public bool Count { get; set; } = false;
        public bool CountAsync { get; set; } = false;
        public bool Add { get; set; } = false;
        public bool AddAsync { get; set; } = false;
        public bool Edit { get; set; } = false;
        public bool EditAsync { get; set; } = false;
        public bool Delete { get; set; } = false;
        public bool DeleteAsync { get; set; } = false;
    }
}
