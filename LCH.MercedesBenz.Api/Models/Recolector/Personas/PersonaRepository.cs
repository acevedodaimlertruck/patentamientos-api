using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Entidades.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Personas
{
    public class PersonaRepository : BaseRecolectorRepository<PersonaEntity>, IPersonaRepository
    {
        public PersonaRepository(RecolectorDbContext context) : base(context)
        {
        }

        public BaseResponse<EntidadDto> GetPersonas(string codVersion, string codVisita)
        {
            try
            {
                var results = (from p in Context.Personas
                               join pf in Context.PersonaFamilias on p.CodPersona equals pf.CodPersona
                               join fv in Context.FamiliaVisitas on pf.CodFamiliaVisita equals fv.CodFamiliaVisita
                               join v in Context.Visitas on fv.CodVisita equals v.CodVisita
                               join r in Context.Respuestas on new
                               {
                                   Activo = (bool?)true,
                                   CodVersion = codVersion,
                                   CodVisita = codVisita,
                                   CodObjeto = "COD_PERSONA",
                                   CodEntidad = p.CodPersona,
                                   CodPreguntaSeccion = "COD_PREG_SEC_428_RELEVAMIENTO",
                               } equals new
                               {
                                   Activo = r.Activo,
                                   CodVersion = r.CodVersion,
                                   CodVisita = r.CodVisita,
                                   CodObjeto = r.CodObjeto,
                                   CodEntidad = r.CodEntidad,
                                   CodPreguntaSeccion = r.CodPreguntaSeccion,
                               } into tempRespuestas
                               from r2 in tempRespuestas.DefaultIfEmpty()
                               where pf.Activo == true && fv.Activo == true && v.Activo == true && fv.CodVisita.Equals(codVisita)
                               select new EntidadDto
                               {
                                   //CodModulo = codModulo,
                                   //Modulo = modulo,
                                   //CodSeccion = codSeccion,
                                   //Seccion = seccionTextoAlternativo,
                                   CodEntidad = p.CodPersona,
                                   CodObjeto = "COD_PERSONA",
                                   NombreCompleto = p.Apellidos + ", " + p.Nombres,
                                   FechaNacimiento = p.FechaNacimiento,
                                   CodSexo = p.CodSexo,
                                   CodTipoEstadoCivil = p.CodTipoEstadoCivil,
                                   FechaRegistroRespuesta = r2 != null ? r2.FechaRegistro : null,
                                   FechaInicialVisita = v.FechaInicial,
                                   CodHogar = pf.CodHogar,
                                   Hogar = pf.Hogar,
                                   JefeDeHogar = pf.JefeDeHogar,
                               }).ToList();
                return new BaseResponse<EntidadDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EntidadDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}