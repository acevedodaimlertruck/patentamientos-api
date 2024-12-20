using LCH.MercedesBenz.Api.Models.Application.Grados.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Grados
{
    public interface IGradoRepository : IBaseRepository<Grado>
    {
        BaseResponse<GradoDto> GetAll2();

        BaseResponse<Grado> Create(GradoDto dto);

        BaseResponse<Grado> Update(GradoDto dto);

    }
}
