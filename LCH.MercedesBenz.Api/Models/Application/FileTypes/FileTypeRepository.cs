using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.FileTypes
{
    public class FileTypeRepository : BaseRepository<FileType>, IFileTypeRepository
    {
        private readonly IMapper _mapper;

        public FileTypeRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<FileTypeDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<FileTypeDto>();
                Expression<Func<FileType, FileTypeDto>> selector = e => new FileTypeDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    Name = e.Name,
                    Description = e.Description,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.FileTypes.Select(selector).ToList();
                    return new BaseResponse<FileTypeDto>(StatusCodes.Status200OK, results);
                }
                Func<FileTypeDto, object> orderBy;
                switch (by)
                {
                    case "AutoId":
                        orderBy = e => e.AutoId;
                        break;
                    case "Name":
                        orderBy = e => e.Name;
                        break;
                    case "UpdatedAt":
                        orderBy = e => e.UpdatedAt;
                        break;
                    default:
                        orderBy = e => e.CreatedAt;
                        break;
                }
                if (direction == Direction.Ascending)
                {
                    results = Context.FileTypes.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<FileTypeDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.FileTypes.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<FileTypeDto>(StatusCodes.Status200OK, results);
                }
                results = Context.FileTypes.Select(selector).ToList();
                return new BaseResponse<FileTypeDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FileTypeDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
