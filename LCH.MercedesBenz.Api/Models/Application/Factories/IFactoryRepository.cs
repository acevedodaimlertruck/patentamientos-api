using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Factories
{
    public interface IFactoryRepository : IBaseRepository<Factory>
    {
        BaseResponse<FactoryDto> GetAll2();

        BaseResponse<Factory> Create(FactoryDto dto);

        BaseResponse<Factory> Update(FactoryDto dto);

        dynamic addJson(dynamic json); 

        dynamic addJsonProv(dynamic json);
    }
}
