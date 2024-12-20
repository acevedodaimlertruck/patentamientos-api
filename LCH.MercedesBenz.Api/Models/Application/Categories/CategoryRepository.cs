using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Categories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly IMapper _mapper;

        public CategoryRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<CategoryDto> GetAll2()
        {
            try
            {
                var results = Context.Categories.Select(i => new CategoryDto
                {
                    Id = i.Id,
                    SegCategory = i.SegCategory,
                    Description = i.Description
                }).OrderBy(i => i.SegCategory).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CategoryDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CategoryDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Category> Create(CategoryDto dto)
        {
            try
            {
                var entity = Context.Categories.SingleOrDefault(p => p.SegCategory!.Equals(dto.SegCategory));
                if (entity != null)
                    return new BaseResponse<Category>(StatusCodes.Status400BadRequest, $"La Categoría ya existe.");
                entity = _mapper.Map<Category>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Category>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Category>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Category> Update(CategoryDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Category>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Categories.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Category>(StatusCodes.Status400BadRequest, $"Id de Categoría no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Category>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Category>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
