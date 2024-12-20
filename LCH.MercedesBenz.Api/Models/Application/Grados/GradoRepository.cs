using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Grados.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Grados
{
    public class GradoRepository : BaseRepository<Grado>, IGradoRepository
    {
        private readonly IMapper _mapper;
        public GradoRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context) 
        {
            _mapper = mapper;
        }

        public BaseResponse<GradoDto> GetAll2()
        {
            try
            {
                var results = Context.Grados.Select(i => new GradoDto
                {
                    Id = i.Id,
                    MarcaWs = i.MarcaWs,
                    ModeloWs = i.ModeloWs,
                    Grade = i.Grade,
                    DateTo = i.DateTo,
                    DateFrom = i.DateFrom,
                    MercedesTerminalId = i.MercedesTerminalId,
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId,
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name,
                                Description = i.CarModel.Brand.Terminal.Description,
                                MercedesTerminalId = i.CarModel.Brand.Terminal.MercedesTerminalId
                            }
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    VersionWs = i.VersionWs,
                    DischargeDate = i.DischargeDate
                }).OrderBy(i => i.Grade).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<GradoDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<GradoDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Grado> Create(GradoDto dto)
        {
            try
            {
                var entity = Context.Grados.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<Grado>(StatusCodes.Status400BadRequest, $"El grado ya existe.");
                entity = _mapper.Map<Grado>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Grado>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Grado>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Grado> Update(GradoDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Grado>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Grados.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Grado>(StatusCodes.Status400BadRequest, $"Id de grado no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Grado>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Grado>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
