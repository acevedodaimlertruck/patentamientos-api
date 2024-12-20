using LCH.MercedesBenz.Api.Models.Application.Provinces.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Provinces
{
    public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<ProvinceDto> GetAll2()
        {
            try
            {
                var results = Context.Provinces.Select(i => new ProvinceDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    MercedesProvinciaId = i.MercedesProvinciaId
                }).OrderBy(i => i.Name).ToList();
                return new BaseResponse<ProvinceDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ProvinceDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
