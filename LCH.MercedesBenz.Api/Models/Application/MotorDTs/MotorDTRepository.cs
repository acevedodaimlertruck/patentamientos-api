using LCH.MercedesBenz.Api.Models.Application.MotorDTs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.MotorDTs
{
    public class MotorDTRepository : BaseRepository<MotorDT>, IMotorDTRepository
    {
        public MotorDTRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<MotorDTDto> GetAll2()
        {
            try
            {
                var results = Context.MotorDTs.Select(i => new MotorDTDto
                {
                    Id = i.Id,
                    MercedesMotorDT = i.MercedesMotorDT,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesMotorDT).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<MotorDTDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<MotorDTDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
