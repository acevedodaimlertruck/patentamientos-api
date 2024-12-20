using LCH.MercedesBenz.Api.Models.Application.EventFiles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles
{
    public interface IEventFileRepository : IBaseRepository<EventFile>
    {
        BaseResponse<EventFileDto> GetAll(string? orderBy = null, Direction direction = Direction.None);

        BaseResponse<EventFile> Create(EventFileCreateOrUpdateDto dto);

        BaseResponse<EventFile> Update(EventFileCreateOrUpdateDto dto);
    }
}
