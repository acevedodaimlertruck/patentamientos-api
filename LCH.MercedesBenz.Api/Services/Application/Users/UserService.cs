using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Users;
using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;

namespace LCH.MercedesBenz.Api.Services.Application.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(
            IMapper mapper,
            IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public BaseResponse<User> Create(UserCreateDto dto)
        {
            try
            {
                var userResponse = _userRepository.GetSingle(u => u.Id.Equals(dto.Id) || u.UserName.Equals(dto.UserName) || u.Dni.Equals(dto.Dni));
                if (userResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<User>(StatusCodes.Status400BadRequest, userResponse.Message, userResponse.StackTrace);
                var user = userResponse.Result;
                if (user != null)
                    return new BaseResponse<User>(StatusCodes.Status400BadRequest, $"User already exists.");
                user = _mapper.Map<User>(dto);
                if (string.IsNullOrEmpty(dto.Id.ToString()))
                    user.Id = Guid.NewGuid();
                else
                    user.Id = Guid.Parse(dto.Id.ToString());
                user.Password = UserRepository.GetBytesFromValue(dto.Password);
                if (!string.IsNullOrEmpty(dto.Pin))
                    user.Pin = UserRepository.GetBytesFromValue(dto.Pin);
                _userRepository.InsertAndSave(user);
                return new BaseResponse<User>(StatusCodes.Status200OK, user);
            }
            catch (Exception e)
            {
                return new BaseResponse<User>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public BaseResponse<User> CreateOrUpdate(UserUpdateDto dto)
        {
            try
            {
                var userResponse = _userRepository.GetSingle(u => u.Id.Equals(dto.Id) || u.UserName.Equals(dto.UserName) || u.Dni.Equals(dto.Dni));
                if (userResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<User>(StatusCodes.Status400BadRequest, userResponse.Message, userResponse.StackTrace);
                var user = userResponse.Result;
                if (user == null)
                {
                    user = _mapper.Map<User>(dto);
                    if (string.IsNullOrEmpty(dto.Id.ToString()))
                        user.Id = Guid.NewGuid();
                    else
                        user.Id = Guid.Parse(dto.Id.ToString());
                    if (!string.IsNullOrEmpty(dto.Password))
                        user.Password = UserRepository.GetBytesFromValue(dto.Password);
                    if (!string.IsNullOrEmpty(dto.Pin))
                        user.Pin = UserRepository.GetBytesFromValue(dto.Pin);
                    _userRepository.InsertAndSave(user);
                }
                else
                {
                    _mapper.Map(dto, user);
                    if (!string.IsNullOrEmpty(dto.Password))
                        user.Password = UserRepository.GetBytesFromValue(dto.Password);
                    if (!string.IsNullOrEmpty(dto.Pin))
                        user.Pin = UserRepository.GetBytesFromValue(dto.Pin);
                    _userRepository.UpdateAndSave(user);
                }
                return new BaseResponse<User>(StatusCodes.Status200OK, user);
            }
            catch (Exception e)
            {
                return new BaseResponse<User>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<User> Update(UserUpdateDto dto)
        {
            try
            {
                if (string.IsNullOrEmpty(dto.Id.ToString()) || string.IsNullOrEmpty(dto.UserName))
                    return new BaseResponse<User>(StatusCodes.Status400BadRequest, $"The fields \"id\" and \"userName\" are required.");
                var userResponse = _userRepository.GetSingle(u => u.Id.Equals(dto.Id) || u.UserName.Equals(dto.UserName));
                if (userResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<User>(StatusCodes.Status400BadRequest, userResponse.Message, userResponse.StackTrace);
                var user = userResponse.Result;
                if (user == null)
                    return new BaseResponse<User>(StatusCodes.Status400BadRequest, $"User not found.");
                _mapper.Map(dto, user);
                if (!string.IsNullOrEmpty(dto.Password))
                    user.Password = UserRepository.GetBytesFromValue(dto.Password);
                if (!string.IsNullOrEmpty(dto.Pin))
                    user.Pin = UserRepository.GetBytesFromValue(dto.Pin);
                _userRepository.UpdateAndSave(user);
                return new BaseResponse<User>(StatusCodes.Status200OK, user);
            }
            catch (Exception e)
            {
                return new BaseResponse<User>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        private void Dispose()
        {
            _userRepository?.Dispose();
        }
    }
}
