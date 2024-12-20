using LCH.MercedesBenz.Api.Models.Application.SpecialSales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SpecialSales
{
    public class SpecialSaleRepository : BaseRepository<SpecialSale>, ISpecialSaleRepository
    {
        public SpecialSaleRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<SpecialSaleDto> GetAll2()
        {
            try
            {
                var results = Context.SpecialSales.Select(i => new SpecialSaleDto
                {
                    Id = i.Id,
                    CuitOwner = i.CuitOwner,
                    Owner = i.Owner,
                    LegalEntity = i.LegalEntity,
                    DescriptionLegalEntity = i.DescriptionLegalEntity,
                    GovernmentalClassification = i.GovernmentalClassification,
                    DescriptionGovernmentalClassification = i.DescriptionGovernmentalClassification,
                    SubgovernmentalClassification = i.SubgovernmentalClassification,
                    DescriptionSubgovernmentalClassification = i.DescriptionSubgovernmentalClassification,
                    CuitClassification = i.CuitClassification,
                    DescriptionCuitClassification = i.DescriptionCuitClassification,
                    Aperture1 = i.Aperture1,
                    DescriptionAperture1 = i.DescriptionAperture1,
                    Aperture2 = i.Aperture2,
                    DescriptionAperture2 = i.DescriptionAperture2,
                    LogisticClassification = i.LogisticClassification,
                    DescriptionLogisticClassification = i.DescriptionLogisticClassification,
                    EstimatedTurnover = i.EstimatedTurnover,
                    DescriptionEstimatedTurnover = i.DescriptionEstimatedTurnover,
                    SocialContractDate = i.SocialContractDate,
                    EmployeesInfo = i.EmployeesInfo
                }).OrderBy(i => i.CuitOwner).ToList();
                return new BaseResponse<SpecialSaleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SpecialSaleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
