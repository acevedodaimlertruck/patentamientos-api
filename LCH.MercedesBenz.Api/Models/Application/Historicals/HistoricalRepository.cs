using LCH.MercedesBenz.Api.Models.Application.Historicals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Historicals
{
    public class HistoricalRepository : BaseRepository<Historical>, IHistoricalRepository
    {
        public HistoricalRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<HistoricalDto> GetAll2()
        {
            try
            {
                var results = Context.Historicals.Select(i => new HistoricalDto
                {
                    Id = i.Id,
                    Plate = i.Plate,
                    Chassis = i.Chassis,
                    NaturalDay = i.NaturalDay,
                    YearMonth = i.YearMonth,
                    NaturalYear = i.NaturalYear,
                    OFMM = i.OFMM,
                    RegDate = i.RegDate,
                    FMM_MTM = i.FMM_MTM,
                    RegNum = i.RegNum,
                    Owner = i.Owner,
                    Address = i.Address,
                    Province = i.Province,
                    Department = i.Department,
                    Location = i.Location,
                    PostalCode = i.PostalCode,
                    Year = i.Year,
                    Car = i.Car,
                    ManufactureCountry = i.ManufactureCountry,
                    OriginCountry = i.OriginCountry,
                    CUITPref = i.CUITPref,
                    PatQuantity = i.PatQuantity,
                    Weight = i.Weight,
                    Origin = i.Origin,
                    Motor = i.Motor,
                    FactoryPat = i.FactoryPat,
                    BrandPat = i.BrandPat,
                    CarModelPat = i.CarModelPat,
                    UploadDate = i.UploadDate,
                    OFMMError = i.OFMMError,
                    IsPatDuplicated = i.IsPatDuplicated,
                    CUITOwner = i.CUITOwner
                }).OrderBy(i => i.Plate).ToList();
                return new BaseResponse<HistoricalDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<HistoricalDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
