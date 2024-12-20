using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.RolePermissions;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;

namespace LCH.MercedesBenz.Api.Services.Application.Roles
{
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IRolePermissionRepository _rolePermissionRepository;
        private readonly IRoleRepository _roleRepository;

        public RoleService(
            IMapper mapper,
            IRolePermissionRepository rolePermissionRepository,
            IRoleRepository roleRepository)
        {
            _mapper = mapper;
            _rolePermissionRepository = rolePermissionRepository;
            _roleRepository = roleRepository;
        }

        public BaseResponse<Role> Create(RoleCreateDto dto)
        {
            try
            {
                var roleResponse = _roleRepository.GetSingle(p => p.Id.Equals(dto.Id));
                if (roleResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<Role>(StatusCodes.Status400BadRequest, roleResponse.Message, roleResponse.StackTrace);
                var role = roleResponse.Result;
                if (role != null)
                    return new BaseResponse<Role>(StatusCodes.Status400BadRequest, $"El rol ya existe.");
                role = _mapper.Map<Role>(dto);
                if (dto.Id == Guid.Empty || dto.Id == null)
                    role.Id = Guid.NewGuid();
                else
                    role.Id = (Guid)dto.Id;
                _roleRepository.InsertAndSave(role);
                var rolePermission = new RolePermission
                {
                    RoleId = role.Id,
                    PermissionId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                };
                _rolePermissionRepository.InsertAndSave(rolePermission);
                return new BaseResponse<Role>(StatusCodes.Status200OK, role);
            }
            catch (Exception e)
            {
                return new BaseResponse<Role>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Role> Update(RoleUpdateDto dto)
        {
            try
            {
                if (string.IsNullOrEmpty(dto.Id))
                    return new BaseResponse<Role>(StatusCodes.Status400BadRequest, $"El parámetro \"id\" es requerido.");
                var roleResponse = _roleRepository.GetSingle(p => p.Id.Equals(Guid.Parse(dto.Id)));
                if (roleResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<Role>(StatusCodes.Status400BadRequest, roleResponse.Message, roleResponse.StackTrace);
                var role = roleResponse.Result;
                if (role == null)
                    return new BaseResponse<Role>(StatusCodes.Status400BadRequest, $"Rol no encontrado.");
                _mapper.Map(dto, role);
                _roleRepository.UpdateAndSave(role);
                return new BaseResponse<Role>(StatusCodes.Status200OK, role);
            }
            catch (Exception e)
            {
                return new BaseResponse<Role>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<bool> UpdatePermissions(RoleDto roleDto)
        {
            try
            {
                if (roleDto == null)
                    return new BaseResponse<bool>(StatusCodes.Status400BadRequest, "El parámetro \"id\" es requerido.");
                var roleResponse = _roleRepository.GetSingle(e => e.Id.Equals(roleDto.Id));
                if (roleResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<bool>(StatusCodes.Status400BadRequest, roleResponse.Message, roleResponse.StackTrace);
                var role = roleResponse.Result;
                if (role == null)
                    return new BaseResponse<bool>(StatusCodes.Status400BadRequest, "Rol no encontrado.");
                _rolePermissionRepository.DeleteAll(roleDto.Id.ToString(), false);
                foreach (var p in roleDto.Permissions)
                {
                    if (!p.Granted || p.Id == null)
                        continue;
                    _rolePermissionRepository.Insert(new RolePermission
                    {
                        RoleId = role.Id,
                        PermissionId = (Guid)p.Id,
                    });
                }
                _rolePermissionRepository.Save();
                return new BaseResponse<bool>(StatusCodes.Status200OK, true);
            }
            catch (Exception e)
            {
                return new BaseResponse<bool>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        private void Dispose()
        {
            _rolePermissionRepository?.Dispose();
            _roleRepository?.Dispose();
        }
    }
}
