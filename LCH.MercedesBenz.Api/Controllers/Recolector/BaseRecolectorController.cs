using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Recolector
{
    //[Authorize]
    [Authorize("LchIdentityServer4Policy", AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class BaseRecolectorController<T> : ControllerBase where T : BaseRecolectorEntity, new()
    {
        public readonly IBaseRecolectorRepository<T> BaseRecolectorRepository;
        public readonly ILogger<BaseRecolectorController<T>> Logger;
        public readonly BaseRecolectorControllerOptions BaseRecolectorControllerOptions;
        const string bc403 = "BC403: Acción prohibida por las opciones del controlador base. Configure la opción correspondiente en su controlador.";

        protected BaseRecolectorController(
            IBaseRecolectorRepository<T> baseRecolectorRepository,
            ILogger<BaseRecolectorController<T>> logger,
            BaseRecolectorControllerOptions? baseControllerOptions = null)
        {
            BaseRecolectorRepository = baseRecolectorRepository;
            Logger = logger;
            if (baseControllerOptions == null)
            {
                BaseRecolectorControllerOptions = new BaseRecolectorControllerOptions();
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
                if (!BaseRecolectorControllerOptions.GetAll)
                {
                    response = new BaseResponse<T>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRecolectorRepository.GetAll();
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
                if (!BaseRecolectorControllerOptions.GetAllAsync)
                {
                    response = new BaseResponse<T>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRecolectorRepository.GetAllAsync();
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
                if (!BaseRecolectorControllerOptions.Count)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRecolectorRepository.Count();
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
                if (!BaseRecolectorControllerOptions.CountAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRecolectorRepository.CountAsync();
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
                if (!BaseRecolectorControllerOptions.Add)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRecolectorRepository.InsertAndSave(value);
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
                if (!BaseRecolectorControllerOptions.AddAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRecolectorRepository.InsertAndSaveAsync(value);
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
                if (!BaseRecolectorControllerOptions.Edit)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRecolectorRepository.UpdateAndSave(value);
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
                if (!BaseRecolectorControllerOptions.EditAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRecolectorRepository.UpdateAndSaveAsync(value);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }

    public class BaseRecolectorControllerOptions
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
