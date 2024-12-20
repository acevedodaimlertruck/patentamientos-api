using System.Data;
using System.Linq.Expressions;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas
{
    public class VisitaRepository : BaseRecolectorRepository<VisitaEntity>, IVisitaRepository
    {
        public VisitaRepository(RecolectorDbContext context) : base(context)
        {
        }

        public BaseResponse<VisitaDto> GetByCustomQuery(VisitaCustomQueryDto query)
        {
            try
            {
                if (query.Page < 0)
                    return new BaseResponse<VisitaDto>(StatusCodes.Status200OK, new List<VisitaDto>());
                Expression<Func<VisitaEntity, bool>> whereTrue = e => true;
                var mWhere = query.Where ?? whereTrue;
                List<VisitaDto> visitas = new List<VisitaDto>();
                if (query.OrderBy == null && query.OrderByDescending == null)
                {
                    visitas = (from v in Context.Visitas.Where(mWhere)
                               join ee in Context.EstadoEncuestas on v.CodEstadoEncuesta equals ee.CodEstadoEncuesta into tmpEstadoEncuestas
                               from ee2 in tmpEstadoEncuestas.DefaultIfEmpty()
                               select new VisitaDto
                               {
                                   CodVisita = v.CodVisita,
                                   Alias = v.Alias,
                                   FechaInicial = v.FechaInicial,
                                   FechaFinal = v.FechaFinal,
                                   Tiempo = v.Tiempo,
                                   EstadoEncuesta = ee2 != null ? ee2.EstadoEncuesta : "",
                                   CodUsuario = v.Usuario,
                                   Usuario = "",
                               })
                            .OrderBy(e => e.Alias)
                            .Skip(query.Page * query.Top)
                            .Take(query.Top)
                            .ToList();
                }
                else if (query.OrderBy != null)
                {
                    visitas = (from v in Context.Visitas.Where(mWhere)
                               join ee in Context.EstadoEncuestas on v.CodEstadoEncuesta equals ee.CodEstadoEncuesta into tmpEstadoEncuestas
                               from ee2 in tmpEstadoEncuestas.DefaultIfEmpty()
                               select new VisitaDto
                               {
                                   CodVisita = v.CodVisita,
                                   Alias = v.Alias,
                                   FechaInicial = v.FechaInicial,
                                   FechaFinal = v.FechaFinal,
                                   Tiempo = v.Tiempo,
                                   EstadoEncuesta = ee2 != null ? ee2.EstadoEncuesta : "",
                                   CodUsuario = v.Usuario,
                                   Usuario = "",
                               })
                            .OrderBy(query.OrderBy)
                            .Skip(query.Page * query.Top)
                            .Take(query.Top)
                            .ToList();
                }
                else
                {
                    visitas = (from v in Context.Visitas.Where(mWhere)
                               join ee in Context.EstadoEncuestas on v.CodEstadoEncuesta equals ee.CodEstadoEncuesta into tmpEstadoEncuestas
                               from ee2 in tmpEstadoEncuestas.DefaultIfEmpty()
                               select new VisitaDto
                               {
                                   CodVisita = v.CodVisita,
                                   Alias = v.Alias,
                                   FechaInicial = v.FechaInicial,
                                   FechaFinal = v.FechaFinal,
                                   Tiempo = v.Tiempo,
                                   EstadoEncuesta = ee2 != null ? ee2.EstadoEncuesta : "",
                                   CodUsuario = v.Usuario,
                                   Usuario = "",
                               })
                        .OrderByDescending(query.OrderByDescending)
                        .Skip(query.Page * query.Top)
                        .Take(query.Top)
                        .ToList();
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
    }
}