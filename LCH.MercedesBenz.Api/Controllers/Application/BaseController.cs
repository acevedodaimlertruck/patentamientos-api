using LCH.MercedesBenz.Api.Models.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Authorize]
    //[Authorize("LchIdentityServer4Policy", AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity, new()
    {
        public readonly IBaseRepository<T> BaseRepository;
        public readonly ILogger<BaseController<T>> Logger;
        public readonly BaseControllerOptions BaseControllerOptions;
        const string bc403 = "BC403: Acción prohibida por las opciones del controlador base. Configure la opción correspondiente en su controlador.";

        protected BaseController(
            IBaseRepository<T> baseRepository,
            ILogger<BaseController<T>> logger,
            BaseControllerOptions? baseControllerOptions = null)
        {
            BaseRepository = baseRepository;
            Logger = logger;
            if (baseControllerOptions == null)
            {
                BaseControllerOptions = new BaseControllerOptions();
            }
            BaseControllerOptions.GetAll = true;
            BaseControllerOptions.GetById = true;
            BaseControllerOptions.Count = true;
            BaseControllerOptions.Add = true;
            BaseControllerOptions.Edit = true;
            BaseControllerOptions.Delete = true;
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
                if (!BaseControllerOptions.GetAll)
                {
                    response = new BaseResponse<T>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRepository.GetAll();
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
                if (!BaseControllerOptions.GetAllAsync)
                {
                    response = new BaseResponse<T>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRepository.GetAllAsync();
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
        [HttpGet, Route("id/{id}")]
        public IActionResult GetById(Guid id)
        {
            BaseResponse<T?>? response;
            try
            {
                if (!BaseControllerOptions.GetById)
                {
                    response = new BaseResponse<T?>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRepository.GetById(id);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<T?>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("async/id/{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            BaseResponse<T?>? response;
            try
            {
                if (!BaseControllerOptions.GetByIdAsync)
                {
                    response = new BaseResponse<T?>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRepository.GetByIdAsync(id);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<T?>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                if (!BaseControllerOptions.Count)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRepository.Count();
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
                if (!BaseControllerOptions.CountAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRepository.CountAsync();
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
                if (!BaseControllerOptions.Add)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRepository.InsertAndSave(value);
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
                if (!BaseControllerOptions.AddAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRepository.InsertAndSaveAsync(value);
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
        [HttpPut, Route("edit/{id}")]
        public IActionResult Edit(string id, [FromBody] T value)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseControllerOptions.Edit)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRepository.UpdateAndSave(value);
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
        [HttpPut, Route("async/edit/{id}")]
        public async Task<IActionResult> EditAsync(Guid id, [FromBody] T value)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseControllerOptions.EditAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRepository.UpdateAndSaveAsync(value);
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
        [HttpDelete, Route("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseControllerOptions.Delete)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = BaseRepository.DeleteByIdAndSave(id);
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
        [HttpDelete, Route("async/delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            BaseResponse<int>? response;
            try
            {
                if (!BaseControllerOptions.DeleteAsync)
                {
                    response = new BaseResponse<int>(StatusCodes.Status403Forbidden, bc403);
                    return StatusCode(StatusCodes.Status403Forbidden, response);
                }
                response = await BaseRepository.DeleteByIdAndSaveAsync(id);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                response = new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }

    public class BaseControllerOptions
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
