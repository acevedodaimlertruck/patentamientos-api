using LCH.MercedesBenz.Api.Models.Application.Locations.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Locations
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<LocationDto> GetAll2()
        {
            try
            {
                var results = Context.Locations.Select(i => new LocationDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    MercedesProvinciaId = i.MercedesProvinciaId,
                    MercedesDepartamentoId = i.MercedesDepartamentoId,
                    MercedesLocalidadId = i.MercedesLocalidadId
                }).OrderBy(i => i.Name).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<LocationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<LocationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
