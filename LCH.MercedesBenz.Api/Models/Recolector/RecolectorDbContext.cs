using LCH.MercedesBenz.Api.Models.Recolector.BloqueGrillas;
using LCH.MercedesBenz.Api.Models.Recolector.Bloques;
using LCH.MercedesBenz.Api.Models.Recolector.ColumnaObjetos;
using LCH.MercedesBenz.Api.Models.Recolector.DatoGeometricos;
using LCH.MercedesBenz.Api.Models.Recolector.EstadoEncuestas;
using LCH.MercedesBenz.Api.Models.Recolector.FamiliaVisitas;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios;
using LCH.MercedesBenz.Api.Models.Recolector.Modulos;
using LCH.MercedesBenz.Api.Models.Recolector.Objetos;
using LCH.MercedesBenz.Api.Models.Recolector.OpcionPreguntas;
using LCH.MercedesBenz.Api.Models.Recolector.PersonaFamilias;
using LCH.MercedesBenz.Api.Models.Recolector.Personas;
using LCH.MercedesBenz.Api.Models.Recolector.PreguntaSecciones;
using LCH.MercedesBenz.Api.Models.Recolector.Respuestas;
using LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetoInvolucrados;
using LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetoMostrar;
using LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos;
using LCH.MercedesBenz.Api.Models.Recolector.Secciones;
using LCH.MercedesBenz.Api.Models.Recolector.SeccionModulos;
using LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas;
using LCH.MercedesBenz.Api.Models.Recolector.Viviendas;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Recolector
{
    public class RecolectorDbContext : DbContext
    {
        public RecolectorDbContext(
            DbContextOptions<RecolectorDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<BloqueGrillaEntity> BloqueGrillas { get; set; }

        public DbSet<BloqueEntity> Bloques { get; set; }

        public DbSet<ColumnaObjetoEntity> ColumnaObjetos { get; set; }

        public DbSet<DatoGeometricoEntity> DatoGeometricos { get; set; }

        public DbSet<EstadoEncuestaEntity> EstadoEncuestas { get; set; }

        public DbSet<FamiliaVisitaEntity> FamiliaVisitas { get; set; }

        public DbSet<FormularioEntity> Formularios { get; set; }

        public DbSet<ModuloEntity> Modulos { get; set; }

        public DbSet<ObjetoEntity> Objetos { get; set; }

        public DbSet<OpcionPreguntaEntity> OpcionPreguntas { get; set; }

        public DbSet<PersonaFamiliaEntity> PersonaFamilias { get; set; }

        public DbSet<PersonaEntity> Personas { get; set; }

        public DbSet<PreguntaSeccionEntity> PreguntaSecciones { get; set; }

        public DbSet<RespuestaEntity> Respuestas { get; set; }

        public DbSet<SaltoObjetoInvolucradoEntity> SaltoObjetoInvolucrados { get; set; }

        public DbSet<SaltoObjetoMostrarEntity> SaltoObjetoMostrar { get; set; }

        public DbSet<SaltoObjetoEntity> SaltoObjetos { get; set; }

        public DbSet<SeccionEntity> Secciones { get; set; }

        public DbSet<SeccionModuloEntity> SeccionModulos { get; set; }

        public DbSet<ValidacionComplejaEntity> ValidacionComplejas { get; set; }

        public DbSet<VersionEntity> Versiones { get; set; }

        public DbSet<VisitaEntity> Visitas { get; set; }

        public DbSet<ViviendaEntity> Viviendas { get; set; }
    }
}
