using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos;
using LCH.MercedesBenz.Api.Models.Universal.Individuos;

namespace LCH.MercedesBenz.Api.Services.Recolector.Visitas
{
    public class VisitaService : IVisitaService
    {
        private readonly IMapper _mapper;
        private readonly IIndividuoRepository _individuoRepository;
        private readonly IVisitaRepository _visitaRepository;

        public VisitaService(
            IMapper mapper,
            IIndividuoRepository individuoRepository,
            IVisitaRepository visitaRepository)
        {
            _mapper = mapper;
            _individuoRepository = individuoRepository;
            _visitaRepository = visitaRepository;
        }

        public BaseResponse<VisitaDto> GetByCustomQuery(VisitaCustomQueryDto query)
        {
            try
            {
                var visitasResponse = _visitaRepository.GetByCustomQuery(query);
                if (visitasResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<VisitaDto>(visitasResponse.StatusCode, visitasResponse.Message, visitasResponse.StackTrace);
                var visitas = visitasResponse.Results;
                var codUsuarios = visitas.Select(v => v.CodUsuario).ToList();
                var individuosResponse = _individuoRepository.GetByCodPersonas(codUsuarios);
                if (individuosResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<VisitaDto>(individuosResponse.StatusCode, individuosResponse.Message, individuosResponse.StackTrace);
                var individuos = individuosResponse.Results;
                foreach (var visita in visitas)
                {
                    var individuo = individuos.FirstOrDefault(i => i.CodPersona.Equals(visita.CodUsuario));
                    if (individuo == null)
                        continue;
                    visita.Usuario = $"{individuo.Apellido} {individuo.Nombre}";
                }
                return new BaseResponse<VisitaDto>(StatusCodes.Status200OK, visitas);
            }
            catch (Exception ex)
            {
                return new BaseResponse<VisitaDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        private void Dispose()
        {
            _individuoRepository?.Dispose();
            _visitaRepository?.Dispose();
        }
    }
}
