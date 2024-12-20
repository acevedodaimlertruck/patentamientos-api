using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Terminals
{
    public interface ITerminalRepository : IBaseRepository<Terminal>
    {
        BaseResponse<TerminalDto> GetAll2();

        BaseResponse<Terminal> Create(TerminalDto dto);

        BaseResponse<Terminal> Update(TerminalDto dto);
        dynamic addJson(dynamic json);
    }
}
