using System.Text;
using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;
using AutoMapper;
using System.Security.Cryptography;
using System.Linq.Expressions;
using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;
using LCH.MercedesBenz.Api.Services.Jwt;
using LCH.MercedesBenz.Api.Models.Application.SecurityParameters;
using LCH.MercedesBenz.Api.Services.HttpContext;

namespace LCH.MercedesBenz.Api.Models.Application.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly ISecurityParameterRepository _securityParameterRepository;
        private readonly IHttpContextService _httpContextService;

        public UserRepository(
            ApplicationDbContext context,
            IConfiguration configuration,
            IMapper mapper,
            ISecurityParameterRepository securityParameterRepository,
            IHttpContextService httpContextService) : base(context)
        {
            _configuration = configuration;
            _mapper = mapper;
            _securityParameterRepository = securityParameterRepository;
            _httpContextService = httpContextService;
        }

        public BaseResponse<UserSignInResponseDto> SignIn(string userName, string password)
        {
            try
            {
                var securityParameters = Context.SecurityParameters.SingleOrDefault();
                var user = (from e in Context.Users
                            where e.UserName.Equals(userName)
                            select new UserSignInResponseDto
                            {
                                Id = e.Id,
                                UserName = e.UserName,
                                Password = e.Password,
                                Pin = e.Pin,
                                Biometric = e.Biometric,
                                Name = e.Name,
                                Surname = e.Surname,
                                Birthdate = e.Birthdate,
                                Email = e.Email,
                                PhoneCountryCode = e.PhoneCountryCode,
                                PhoneAreaCode = e.PhoneAreaCode,
                                PhoneNumber = e.PhoneNumber,
                                FullPhoneNumber = e.FullPhoneNumber,
                                Photo = e.Photo,
                                RoleId = e.RoleId,
                                Role = e.Role == null ? null : new RoleDto
                                {
                                    Id = e.Role.Id,
                                    Name = e.Role.Name,
                                },
                                Dni = e.Dni,
                            }).SingleOrDefault();
                if (user == null)
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Usuario y/o contraseña incorrectos.");
                if (!CheckHashes(user.Password, password))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Usuario y/o contraseña incorrectos.");
                var secretKey = _configuration["Authentication:Internal:SecretKey"];
                var expires = securityParameters != null ? securityParameters.SessionTime : int.Parse(_configuration["Authentication:Internal:Expires:Default"]);
                var token = JwtService.GetToken(user, secretKey, expires);
                if (string.IsNullOrEmpty(token))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "El Token es nulo o vacío.");
                user.Token = token;
                user.Password = null;
                return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status200OK, user);
            }
            catch (Exception ex)
            {
                return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<string> RefreshToken(Guid userId)
        {
            try
            {
                var securityParameters = Context.SecurityParameters.SingleOrDefault();
                var user = (from e in Context.Users
                            where e.Id.Equals(userId)
                            select new UserSignInResponseDto
                            {
                                Id = e.Id,
                                UserName = e.UserName,
                                Password = e.Password,
                                Pin = e.Pin,
                                Biometric = e.Biometric,
                                Name = e.Name,
                                Surname = e.Surname,
                                Birthdate = e.Birthdate,
                                Email = e.Email,
                                PhoneCountryCode = e.PhoneCountryCode,
                                PhoneAreaCode = e.PhoneAreaCode,
                                PhoneNumber = e.PhoneNumber,
                                FullPhoneNumber = e.FullPhoneNumber,
                                Photo = e.Photo,
                                RoleId = e.RoleId,
                                Role = e.Role == null ? null : new RoleDto
                                {
                                    Id = e.Role.Id,
                                    Name = e.Role.Name,
                                },
                                Dni = e.Dni,
                            }).SingleOrDefault();
                if (user == null)
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, "Usuario no encontrado.");
                var secretKey = _configuration["Authentication:Internal:SecretKey"];
                var expires = securityParameters != null ? securityParameters.SessionTime : int.Parse(_configuration["Authentication:Internal:Expires:Default"]);
                var token = JwtService.GetToken(user, secretKey, expires);
                if (string.IsNullOrEmpty(token))
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, "El Token es nulo o vacío.");
                var response = new BaseResponse<string>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Result = token,
                };
                return response;
            }
            catch (Exception ex)
            {
                return new BaseResponse<string>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<UserSignInResponseDto> SetPwd(SetPwdDto setPwdDto)
        {
            try
            {
                var fromUserId = _httpContextService.GetUserId();
                if (string.IsNullOrEmpty(fromUserId))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Token inválido.");
                if (setPwdDto == null
                    || string.IsNullOrEmpty(setPwdDto.OldPassword)
                    || string.IsNullOrEmpty(setPwdDto.NewPassword)
                    || string.IsNullOrEmpty(setPwdDto.RepeatPassword))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Los campos oldPassword, newPassword y repeatPassword son requeridos.");
                if (!setPwdDto.NewPassword.Equals(setPwdDto.RepeatPassword))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Los campos newPassword y repeatPassword no coinciden.");
                if (setPwdDto.NewPassword.Equals(setPwdDto.OldPassword))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "La nueva contraseña no puede ser igual a la anterior.");
                var userResponse = GetSingle(u => u.Id.Equals(setPwdDto.Id));
                if (userResponse == null || userResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Usuario no encontrado.");
                var user = userResponse.Result;
                if (user == null)
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Usuario no encontrado.");
                if (!CheckHashes(user.Password, setPwdDto.OldPassword))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Contraseña anterior incorrecta.");
                user.Password = GetBytesFromValue(setPwdDto.NewPassword);
                UpdateAndSave(user);
                var secretKey = _configuration["Authentication:Internal:SecretKey"];
                var expires = int.Parse(_configuration["Authentication:Internal:Expires:Default"]);
                var userSignInResponseDto = (from e in Context.Users
                                             where e.Id.Equals(setPwdDto.Id)
                                             select new UserSignInResponseDto
                                             {
                                                 Id = e.Id,
                                                 UserName = e.UserName,
                                                 Password = e.Password,
                                                 Pin = e.Pin,
                                                 Biometric = e.Biometric,
                                                 Name = e.Name,
                                                 Surname = e.Surname,
                                                 Birthdate = e.Birthdate,
                                                 Email = e.Email,
                                                 PhoneCountryCode = e.PhoneCountryCode,
                                                 PhoneAreaCode = e.PhoneAreaCode,
                                                 PhoneNumber = e.PhoneNumber,
                                                 FullPhoneNumber = e.FullPhoneNumber,
                                                 Photo = e.Photo,
                                                 RoleId = e.RoleId,
                                                 Role = e.Role == null ? null : new RoleDto
                                                 {
                                                     Id = e.Role.Id,
                                                     Name = e.Role.Name,
                                                 },
                                             }).SingleOrDefault();
                var token = JwtService.GetToken(userSignInResponseDto, secretKey, expires);
                if (string.IsNullOrEmpty(token))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Token is null or empty.");
                userSignInResponseDto.Token = token;
                userSignInResponseDto.Password = null;
                return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status200OK, userSignInResponseDto);
            }
            catch (Exception ex)
            {
                return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<string> CreatePin(string id, string newPin, string confirmPin)
        {
            try
            {
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(newPin) || string.IsNullOrEmpty(confirmPin))
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, $"The fields \"id\", \"newPin\" and \"confirmPin\" are required.");
                var entity = Context.Users.SingleOrDefault(p => p.Id.Equals(id));
                if (entity == null)
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, $"User not found (Id={id}).");
                if (newPin != confirmPin)
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, "El nuevo PIN y la confirmacion de PIN son distintos");
                var bytes = GetBytesFromValue(newPin);
                var hash = GetHashFromBytes(bytes);
                entity.Pin = bytes;
                UpdateAndSave(entity);
                var response = new BaseResponse<string>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Result = hash
                };
                return response;
            }
            catch (Exception e)
            {
                return new BaseResponse<string>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<string> UpdatePin(string id, string pin, string newPin, string confirmPin)
        {
            try
            {
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pin) || string.IsNullOrEmpty(newPin) || string.IsNullOrEmpty(confirmPin))
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, $"The fields \"id\", \"pin\", \"newPin\" and \"confirmPin\" are required.");
                var entity = Context.Users.SingleOrDefault(p => p.Id.Equals(id));
                if (entity == null)
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, $"User not found (Id={id}).");
                if (!CheckHashes(entity.Pin, pin))
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, "El PIN actual ingresado no es correcto.");
                if (newPin != confirmPin)
                    return new BaseResponse<string>(StatusCodes.Status400BadRequest, "El nuevo PIN y la confirmacion de PIN son distintos");
                var bytes = GetBytesFromValue(newPin);
                var hash = GetHashFromBytes(bytes);
                entity.Pin = bytes;
                UpdateAndSave(entity);
                var response = new BaseResponse<string>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Result = hash
                };
                return response;
            }
            catch (Exception e)
            {
                return new BaseResponse<string>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        private static string GetHashFromValue(string value)
        {
            // Create a SHA256   
            using (SHA256 sha256 = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static byte[] GetBytesFromValue(string value)
        {
            // Create a SHA256   
            using (SHA256 sha256 = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));
                return bytes;
            }
        }

        private static string GetHashFromBytes(byte[] bytes)
        {
            // Create a SHA256   
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool CheckHashes(byte[] bytes, string compareValue)
        {
            var hash1 = GetHashFromBytes(bytes);
            var hash2 = GetHashFromValue(compareValue);
            return hash1.Equals(hash2);
        }

        public BaseResponse<int> Count(List<Filter> filters)
        {
            try
            {
                Expression<Func<User, bool>> where = e => true;
                foreach (var filter in filters)
                {
                    if (string.IsNullOrEmpty(filter?.Value)) continue;
                    Expression<Func<User, bool>> w = e => true;
                    switch (filter.By)
                    {
                        case "AutoIdOrUserNameOrNameOrSurename":
                            w = e => e.AutoId.ToString().Equals(filter.Value) || e.UserName.Equals(filter.Value) || e.Name.Contains(filter.Value) || e.Surname.Contains(filter.Value);
                            break;
                        default:
                            continue;
                    }
                    where = where.And(w);
                }
                return Count(where);
            }
            catch (Exception e)
            {
                return new BaseResponse<int>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<QueryDto<UserDto>> Paginate(QueryDto<UserDto> page)
        {
            try
            {
                var query = new UserPageQuery(page.Page.PageNumber, page.Page.Top);

                if (!string.IsNullOrEmpty(page.Order?.By))
                {
                    Func<UserDto, object> orderBy;
                    switch (page.Order.By)
                    {
                        case "AutoId":
                            orderBy = e => e.AutoId;
                            break;
                        case "UserName":
                            orderBy = e => e.UserName;
                            break;
                        case "Name":
                            orderBy = e => e.Name;
                            break;
                        case "Surname":
                            orderBy = e => e.Surname;
                            break;
                        default:
                            orderBy = e => e.UpdatedAt;
                            break;
                    }
                    switch (page.Order.Direction)
                    {
                        case Direction.Ascending:
                            query.OrderBy = orderBy;
                            break;
                        case Direction.Descending:
                            query.OrderByDescending = orderBy;
                            break;
                    }
                }

                query.Where = e => !e.RoleId.Equals("ID_BUYER") && !e.RoleId.Equals("ID_SELLER");
                foreach (var filter in page.Filters)
                {
                    if (string.IsNullOrEmpty(filter?.Value)) continue;
                    Expression<Func<User, bool>> w = e => true;
                    switch (filter.By)
                    {
                        case "AutoIdOrUserNameOrNameOrSurename":
                            w = e => e.AutoId.ToString().Equals(filter.Value) || e.UserName.Equals(filter.Value) || e.Name.Contains(filter.Value) || e.Surname.Contains(filter.Value);
                            break;
                        default:
                            continue;
                    }
                    query.Where = query.Where.And(w);
                }

                if (query.Page < 0)
                {
                    page.Results = new List<UserDto>();
                    return new BaseResponse<QueryDto<UserDto>>(StatusCodes.Status200OK, page);
                }

                Expression<Func<User, bool>> whereTrue = e => true;
                var where = query.Where ?? whereTrue;

                var results = new List<UserDto>();

                Expression<Func<User, UserDto>> selector = e => new UserDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    RoleId = e.RoleId,
                    UserName = e.UserName,
                    Name = e.Name,
                    Surname = e.Surname,
                    Birthdate = e.Birthdate,
                    Email = e.Email,
                    PhoneCountryCode = e.PhoneCountryCode,
                    PhoneAreaCode = e.PhoneAreaCode,
                    PhoneNumber = e.PhoneNumber,
                    FullPhoneNumber = e.FullPhoneNumber,
                    Photo = e.Photo,
                    CreatedAt = e.CreatedAt,
                    Dni= e.Dni,
                    UpdatedAt = e.UpdatedAt,
                    Role = e.Role == null ? null : new RoleDto
                    {
                        Id = e.Role.Id,
                        AutoId = e.Role.AutoId,
                        Name = e.Role.Name,
                        Description = e.Role.Description
                    },
                };

                if (query.OrderBy == null && query.OrderByDescending == null)
                {
                    results = Context.Users.Where(where).Select(selector)
                        .OrderByDescending(e => e.UpdatedAt)
                        .Skip(query.Page * query.Top)
                        .Take(query.Top)
                        .ToList();
                }

                if (query.OrderBy != null)
                {
                    results = Context.Users.Where(where).Select(selector)
                        .OrderBy(query.OrderBy)
                        .Skip(query.Page * query.Top)
                        .Take(query.Top)
                        .ToList();
                }

                if (query.OrderByDescending != null)
                {
                    results = Context.Users.Where(where).Select(selector)
                        .OrderByDescending(query.OrderByDescending)
                        .Skip(query.Page * query.Top)
                        .Take(query.Top)
                        .ToList();
                }

                page.Results = results;
                return new BaseResponse<QueryDto<UserDto>>(StatusCodes.Status200OK, page);
            }
            catch (Exception e)
            {
                return new BaseResponse<QueryDto<UserDto>>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<UserDto> GetById2(Guid id)
        {
            try
            {
                var result = Context.Users.Where(e => e.Id.Equals(id)).Select(e => new UserDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    RoleId = e.RoleId,
                    UserName = e.UserName,
                    Name = e.Name,
                    Surname = e.Surname,
                    Birthdate = e.Birthdate,
                    Email = e.Email,
                    PhoneCountryCode = e.PhoneCountryCode,
                    PhoneAreaCode = e.PhoneAreaCode,
                    PhoneNumber = e.PhoneNumber,
                    FullPhoneNumber = e.FullPhoneNumber,
                    Photo = e.Photo,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                    Dni= e.Dni,
                    Role = e.Role == null ? null : new RoleDto
                    {
                        Id = e.Role.Id,
                        AutoId = e.Role.AutoId,
                        Name = e.Role.Name,
                        Description = e.Role.Description
                    },
                }).SingleOrDefault();
                return new BaseResponse<UserDto>(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return new BaseResponse<UserDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<UserSignInResponseDto> SignInWithPin(string userName, string pin, string secretKey, int expires)
        {
            try
            {
                var user = (from e in Context.Users
                            where e.UserName.Equals(userName)
                            select new UserSignInResponseDto
                            {
                                Id = e.Id,
                                UserName = e.UserName,
                                Password = e.Password,
                                Pin = e.Pin,
                                Biometric = e.Biometric,
                                Name = e.Name,
                                Surname = e.Surname,
                                Birthdate = e.Birthdate,
                                Email = e.Email,
                                PhoneCountryCode = e.PhoneCountryCode,
                                PhoneAreaCode = e.PhoneAreaCode,
                                PhoneNumber = e.PhoneNumber,
                                FullPhoneNumber = e.FullPhoneNumber,
                                Photo = e.Photo,
                                RoleId = e.RoleId,
                                Dni=e.Dni,
                            }).SingleOrDefault();
                if (user == null)
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Incorrect UserName or PIN.");
                if (!CheckHashes(user.Pin, pin))
                    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Incorrect UserName or PIN.");
                //var token = JwtService.GetToken(user, secretKey, expires);
                //if (string.IsNullOrEmpty(token))
                //    return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status400BadRequest, "Token is null or empty.");
                //user.Token = token;
                user.Password = null;
                return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status200OK, user);
            }
            catch (Exception ex)
            {
                return new BaseResponse<UserSignInResponseDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
