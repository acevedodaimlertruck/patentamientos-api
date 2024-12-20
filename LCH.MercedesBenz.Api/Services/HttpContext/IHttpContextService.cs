namespace LCH.MercedesBenz.Api.Services.HttpContext
{
    public interface IHttpContextService
    {
        string? GetUserId();

        string? GetName();

        string? GetSurname();

        string? GetDisplayName();

        string? GetRoleId();

        string? GetObjectId();
    }
}
