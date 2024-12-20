using LCH.MercedesBenz.Api.Models.Application.FuelTypes;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Tractions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.FuelTypes
{
    public class FuelTypeRepository : BaseRepository<FuelType>, IFuelTypeRepository
    {
        public FuelTypeRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<FuelTypeDto> GetAll2()
        {
            try
            {
                var results = Context.FuelTypes.Select(i => new FuelTypeDto
                {
                    Id = i.Id,
                    MercedesFuelType = i.MercedesFuelType,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesFuelType).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<FuelTypeDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FuelTypeDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
