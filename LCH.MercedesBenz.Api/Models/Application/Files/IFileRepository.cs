using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Files
{
    public interface IFileRepository : IBaseRepository<File>
    {
        BaseResponse<FileDto> GetAll(string? orderBy = null, Direction direction = Direction.None);

        BaseResponse<FileDto> GetAll2();

        Task<BaseResponse<File>> CreateAsync(FileCreateOrUpdateDto dto);

        BaseResponse<dynamic> GetByFileId(Guid fileId, bool dispose = true);

        BaseResponse<File> Update(FileCreateOrUpdateDto dto);

        BaseResponse<dynamic> DeleteFile(Guid fileId);
    }
}
