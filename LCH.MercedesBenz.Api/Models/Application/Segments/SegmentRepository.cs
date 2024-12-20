using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Segments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Segments
{
    public class SegmentRepository : BaseRepository<Segment>, ISegmentRepository
    {
        private readonly IMapper _mapper;

        public SegmentRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<SegmentDto> GetAll2()
        {
            try
            {
                var results = Context.Segments.Select(i => new SegmentDto
                {
                    Id = i.Id,
                    MercedesCategoriaId = i.MercedesCategoriaId,
                    SegName = i.SegName,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.Id).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<SegmentDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SegmentDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Segment> Create(SegmentDto dto)
        {
            try
            {
                var entity = Context.Segments.SingleOrDefault(p => p.SegName!.Equals(dto.SegName));
                if (entity != null)
                    return new BaseResponse<Segment>(StatusCodes.Status400BadRequest, $"El Segmento ya existe.");
                entity = _mapper.Map<Segment>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Segment>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Segment>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Segment> Update(SegmentDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Segment>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Segments.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Segment>(StatusCodes.Status400BadRequest, $"Id de Segmento no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Segment>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Segment>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
