using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios.Dtos;
using LCH.MercedesBenz.Api.Models.Universal.UsuarioOrganizaciones;

namespace LCH.MercedesBenz.Api.Services.Recolector.Formularios
{
    public class FormularioService : IFormularioService
    {
        private readonly IMapper _mapper;
        private readonly IFormularioRepository _formularioRepository;
        private readonly IUsuarioOrganizacionRepository _usuarioOrganizacionRepository;

        public FormularioService(
            IMapper mapper,
            IFormularioRepository formularioRepository,
            IUsuarioOrganizacionRepository usuarioOrganizacionRepository)
        {
            _mapper = mapper;
            _formularioRepository = formularioRepository;
            _usuarioOrganizacionRepository = usuarioOrganizacionRepository;
        }

        public BaseResponse<FormularioDto> GetByCodUsuario(string codUsuario)
        {
            try
            {
                var codOrganizacionesResponse = _usuarioOrganizacionRepository.GetCodOrganizaciones(codUsuario);
                if (codOrganizacionesResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<FormularioDto>(codOrganizacionesResponse.StatusCode, codOrganizacionesResponse.Message, codOrganizacionesResponse.StackTrace);
                var codOrganizaciones = codOrganizacionesResponse.Results.ToList();
                var formulariosResponse = _formularioRepository.GetByCodOrganizaciones(codOrganizaciones);
                if (formulariosResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<FormularioDto>(formulariosResponse.StatusCode, formulariosResponse.Message, formulariosResponse.StackTrace);
                var results = formulariosResponse.Results;
                return new BaseResponse<FormularioDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FormularioDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<FormularioDto> GetByCodUsuarioAndCodVersion(string codUsuario, string codVersion)
        {
            try
            {
                var codOrganizacionesResponse = _usuarioOrganizacionRepository.GetCodOrganizaciones(codUsuario);
                if (codOrganizacionesResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<FormularioDto>(codOrganizacionesResponse.StatusCode, codOrganizacionesResponse.Message, codOrganizacionesResponse.StackTrace);
                var codOrganizaciones = codOrganizacionesResponse.Results.ToList();
                var formularioResponse = _formularioRepository.GetByCodVersionAndCodOrganizaciones(codVersion, codOrganizaciones);
                if (formularioResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<FormularioDto>(formularioResponse.StatusCode, formularioResponse.Message, formularioResponse.StackTrace);
                var result = formularioResponse.Result;
                return new BaseResponse<FormularioDto>(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FormularioDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        private void Dispose()
        {
            _formularioRepository?.Dispose();
            _usuarioOrganizacionRepository?.Dispose();
        }
    }
}
