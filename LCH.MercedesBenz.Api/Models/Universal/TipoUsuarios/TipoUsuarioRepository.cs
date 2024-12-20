namespace LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios
{
    public class TipoUsuarioRepository : BaseUniversalRepository<TipoUsuarioEntity>, ITipoUsuarioRepository
    {
        public TipoUsuarioRepository(UniversalDbContext context) : base(context)
        {
        }
    }
}
