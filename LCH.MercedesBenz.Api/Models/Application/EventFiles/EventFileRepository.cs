using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.EventFiles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles
{
    public class EventFileRepository : BaseRepository<EventFile>, IEventFileRepository
    {
        private readonly IMapper _mapper;

        public EventFileRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<EventFileDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<EventFileDto>();
                Expression<Func<EventFile, EventFileDto>> selector = e => new EventFileDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    FileID = e.FileID,
                    Status = e.Status,
                    UserName = e.UserName,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.EventFiles.Select(selector).ToList();
                    return new BaseResponse<EventFileDto>(StatusCodes.Status200OK, results);
                }
                Func<EventFileDto, object> orderBy;
                switch (by)
                {
                    case "AutoId":
                        orderBy = e => e.AutoId;
                        break;
                    case "Status":
                        orderBy = e => e.Status;
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
                    results = Context.EventFiles.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<EventFileDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.EventFiles.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<EventFileDto>(StatusCodes.Status200OK, results);
                }
                results = Context.EventFiles.Select(selector).ToList();
                return new BaseResponse<EventFileDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EventFileDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<EventFile> Create(EventFileCreateOrUpdateDto dto)
        {
            try
            {
                if (dto.FileID == Guid.Empty)
                    return new BaseResponse<EventFile>(StatusCodes.Status400BadRequest, "El parámetro FileID es requerido.");
                var file = Context.EventFiles.Where(pn => pn.Id.Equals(dto.Id)).SingleOrDefault();
                if (file != null)
                    return new BaseResponse<EventFile>(StatusCodes.Status400BadRequest, "El archivo ya existe.");
                file = _mapper.Map<EventFile>(dto);
                if (dto.Id == Guid.Empty || dto.Id == null)
                    file.Id = Guid.NewGuid();
                else
                    file.Id = (Guid)dto.Id;
                InsertAndSave(file);
                return new BaseResponse<EventFile>(StatusCodes.Status200OK, file);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EventFile>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<EventFile> Update(EventFileCreateOrUpdateDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<EventFile>(StatusCodes.Status400BadRequest, "El parámetro Id es requerido.");
                var eventFile = Context.EventFiles.Where(pn => pn.Id.Equals(dto.Id)).SingleOrDefault();
                if (eventFile == null)
                    return new BaseResponse<EventFile>(StatusCodes.Status400BadRequest, "Estandar no encontrado.");
                _mapper.Map(dto, eventFile);
                UpdateAndSave(eventFile);
                return new BaseResponse<EventFile>(StatusCodes.Status200OK, eventFile);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EventFile>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
