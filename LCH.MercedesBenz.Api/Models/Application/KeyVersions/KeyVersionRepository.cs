using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.KeyVersions
{
    public class KeyVersionRepository : BaseRepository<KeyVersion>, IKeyVersionRepository
    {
        private readonly IMapper _mapper;

        public KeyVersionRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<KeyVersionDto> GetAll2()
        {
            try
            {
                var results = Context.KeyVersions.Select(i => new KeyVersionDto
                {
                    Id = i.Id,
                    MercedesTerminalId = i.MercedesTerminalId,
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId,
                    MercedesVersionClaveId = i.MercedesVersionClaveId,
                    MercedesVersionInternaId = i.MercedesVersionInternaId,
                    DateTo = i.DateTo,
                    DateFrom = i.DateFrom,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong,
                    SegCategory = i.SegCategory,
                    SegName = i.SegName
                }).OrderBy(i => i.Id).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<KeyVersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<KeyVersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<KeyVersion> Create(KeyVersionDto dto)
        {
            try
            {
                var entity = Context.KeyVersions.SingleOrDefault(p => p.MercedesVersionClaveId!.Equals(dto.MercedesVersionClaveId));
                if (entity != null)
                    return new BaseResponse<KeyVersion>(StatusCodes.Status400BadRequest, $"La Versión Clave ya existe.");
                entity = _mapper.Map<KeyVersion>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<KeyVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<KeyVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<KeyVersion> Update(KeyVersionDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<KeyVersion>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.KeyVersions.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<KeyVersion>(StatusCodes.Status400BadRequest, $"Id de Versión Clave no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<KeyVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<KeyVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
