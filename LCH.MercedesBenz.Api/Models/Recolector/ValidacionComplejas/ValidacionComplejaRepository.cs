using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas
{
    public class ValidacionComplejaRepository : BaseRecolectorRepository<ValidacionComplejaEntity>, IValidacionComplejaRepository
    {
        public ValidacionComplejaRepository(RecolectorDbContext context) : base(context)
        {
        }

        public BaseResponse<ValidacionComplejaDto> GetByCodVersion(string codVersion)
        {
            try
            {
                var results = Context.ValidacionComplejas
                    .Where(vc => vc.Activo == true && vc.CodVersion.Equals(codVersion))
                    .Select(vc => new ValidacionComplejaDto
                    {
                        IdValidacionCompleja = vc.IdValidacionCompleja,
                        CodValidacionCompleja = vc.CodValidacionCompleja,
                        CodVersion = vc.CodVersion,
                        CodObjeto = vc.CodObjeto,
                        CodTipoObjeto = vc.CodTipoObjeto,
                        CodEvento = vc.CodEvento,
                        Funcion = vc.Funcion,
                        Descripcion = vc.Descripcion,
                        FechaCreacion = vc.FechaCreacion,
                    }).ToList();
                return new BaseResponse<ValidacionComplejaDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ValidacionComplejaDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}