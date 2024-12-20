using LCH.MercedesBenz.Api.Models.Universal.Individuos;
using LCH.MercedesBenz.Api.Models.Universal.Sistemas;
using LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios;
using LCH.MercedesBenz.Api.Models.Universal.UsuarioOrganizaciones;
using LCH.MercedesBenz.Api.Models.Universal.Usuarios;
using LCH.MercedesBenz.Api.Models.Universal.UsuarioSistemas;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Universal
{
    public class UniversalDbContext : DbContext
    {
        public UniversalDbContext(
            DbContextOptions<UniversalDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<IndividuoEntity> Individuos { get; set; }

        public virtual DbSet<SistemaEntity> Sistemas { get; set; }

        public virtual DbSet<TipoUsuarioEntity> TipoUsuarios { get; set; }

        public virtual DbSet<UsuarioOrganizacionEntity> UsuarioOrganizaciones { get; set; }

        public virtual DbSet<UsuarioEntity> Usuarios { get; set; }

        public virtual DbSet<UsuarioSistemaEntity> UsuarioSistemas { get; set; }
    }
}
