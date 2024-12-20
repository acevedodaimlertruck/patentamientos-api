using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.FileTypes
{
    public interface IFileTypeRepository : IBaseRepository<FileType>
    {
        BaseResponse<FileTypeDto> GetAll(string? orderBy = null, Direction direction = Direction.None);

    }
}
