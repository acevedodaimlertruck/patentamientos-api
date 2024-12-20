namespace LCH.MercedesBenz.Api.Services.HttpContext
{
    public class HttpContextService : IHttpContextService
    {
        private readonly IHttpContextAccessor _context;

        public HttpContextService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string? GetUserId()
        {
            return _context?.HttpContext?.User?.Identity?.Name;
        }

        public string? GetName()
        {
            return _context?.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type.Equals("name"))?.Value ?? null;
        }

        public string? GetSurname()
        {
            return _context?.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type.Equals("surname"))?.Value ?? null;
        }

        public string? GetDisplayName()
        {
            return _context?.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type.Equals("display_name"))?.Value ?? null;
        }

        public string? GetRoleId()
        {
            return _context?.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == "roleId")?.Value ?? null;
        }

        public string? GetObjectId()
        {
            return _context?.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == "objectId")?.Value ?? null;
        }
    }
}
