using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using LCH.MercedesBenz.Api.Models.Application.Users;
using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;
using LCH.MercedesBenz.Api.Services.Application.Users;
using LCH.MercedesBenz.Api.Services.HttpContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Controllers.Application
{
    [Route("api/Users")]
    public class UsersController : BaseController<User>
    {
        private readonly IBaseRepository<User> _repository;
        private readonly ILogger<UsersController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextService _httpContextService;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserService _userService;

        public UsersController(
            IBaseRepository<User> repository,
            ILogger<UsersController> logger,
            IConfiguration configuration,
            IHttpContextService httpContextService,
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            IUserService userService) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _httpContextService = httpContextService;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("sign-in")]
        public IActionResult SignIn(SignInDto signInDto)
        {
            var response = _userRepository.SignIn(signInDto.UserName, signInDto.Password);
            if (response.StatusCode != StatusCodes.Status200OK)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("refresh-token")]
        public IActionResult RefreshToken()
        {
            var userId = _httpContextService.GetUserId();
            var userGuid = Guid.Parse(userId);
            var response = _userRepository.RefreshToken(userGuid);
            return StatusCode(response.StatusCode, response);
        }

        [AllowAnonymous]
        [HttpPost("sign-in-with-pin")]
        public IActionResult BuyerSignInWithPin(SignInWithPinDto signInWithPinDto)
        {
            var secretKey = _configuration["Authentication:Jwt:SecretKey"];
            var expiresInDays = int.Parse(_configuration["Authentication:Jwt:ExpiresInDays"]);
            var response = _userRepository.SignInWithPin(signInWithPinDto.UserName, signInWithPinDto.Pin, secretKey, expiresInDays);
            if (response.StatusCode != StatusCodes.Status200OK)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost("set-pwd")]
        public IActionResult SetPwd(SetPwdDto setPwdDto)
        {
            var response = _userRepository.SetPwd(setPwdDto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("create-pin")]
        public IActionResult CreatePin(string id, string newPin, string confirmPin)
        {
            var response = _userRepository.CreatePin(id, newPin, confirmPin);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update-pin")]
        public IActionResult UpdatePin(string id, string pin, string newPin, string confirmPin)
        {
            var response = _userRepository.UpdatePin(id, pin, newPin, confirmPin);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("page/count")]
        public IActionResult Paginate(List<Filter> filters)
        {
            var response = _userRepository.Count(filters);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpGet, Route("by-id")]
        public IActionResult GetById2(Guid id)
        {
            var response = _userRepository.GetById2(id);
            return StatusCode(response.StatusCode, response);
        }
#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("page/paginate")]
        public IActionResult Paginate(QueryDto<UserDto> dto)
        {
            var response = _userRepository.Paginate(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPost, Route("create")]
        public IActionResult Create(UserCreateDto dto)
        {
            var response = _userService.Create(dto);
            return StatusCode(response.StatusCode, response);
        }

#if DEBUG
        [AllowAnonymous]
#endif
        [HttpPut, Route("update")]
        public IActionResult Update(UserUpdateDto dto)
        {
            var response = _userService.Update(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
