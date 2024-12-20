namespace LCH.MercedesBenz.Api.Models.Universal.Usuarios
{
    public class UsuarioRepository : BaseUniversalRepository<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(UniversalDbContext context) : base(context)
        {
        }
    }
}
