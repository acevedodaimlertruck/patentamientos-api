namespace LCH.MercedesBenz.Api.Models.Universal.UsuarioSistemas
{
    public class UsuarioSistemaRepository : BaseUniversalRepository<UsuarioSistemaEntity>, IUsuarioSistemaRepository
    {
        public UsuarioSistemaRepository(UniversalDbContext context) : base(context)
        {
        }
    }
}
