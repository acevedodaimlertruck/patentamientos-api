using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CuitClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers.Dtos;
using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.LegalEntities.Dtos;
using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications
{
    public class OdsOwnerClassificationRepository : BaseRepository<OdsOwnerClassification>, IOdsOwnerClassificationRepository
    {
        private readonly IMapper _mapper;

        public OdsOwnerClassificationRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<OdsOwnerClassificationDto> GetAll2()
        {
            try
            {
                var results = Context.OdsOwnerClassifications.Select(i => new OdsOwnerClassificationDto
                {
                    Id = i.Id,
                    CuitOwner = i.CuitOwner,
                    Owner = i.Owner,
                    MercedesLegalEntity = i.MercedesLegalEntity,
                    LegalEntityId = i.LegalEntityId,
                    LegalEntity = i.LegalEntity == null ? null : new LegalEntityDto
                    {
                        Id = i.LegalEntity.Id,
                        MercedesLegalEntity = i.LegalEntity.MercedesLegalEntity,
                        DescriptionShort = i.LegalEntity.DescriptionShort,
                        DescriptionLong = i.LegalEntity.DescriptionLong
                    },
                    MercedesGovernmentalClassification = i.MercedesGovernmentalClassification,
                    GovernmentalClassificationId = i.GovernmentalClassificationId,
                    GovernmentalClassification = i.GovernmentalClassification == null ? null : new GovernmentalClassificationDto
                    {
                        Id = i.GovernmentalClassification.Id,
                        MercedesGovernmentalClassification = i.GovernmentalClassification.MercedesGovernmentalClassification,
                        DescriptionShort = i.GovernmentalClassification.DescriptionShort,
                        DescriptionLong = i.GovernmentalClassification.DescriptionLong
                    },
                    MercedesSubgovernmentalClassification = i.MercedesSubgovernmentalClassification,
                    SubgovernmentalClassificationId = i.SubgovernmentalClassificationId,
                    SubgovernmentalClassification = i.SubgovernmentalClassification == null ? null : new SubgovernmentalClassificationDto
                    {
                        Id = i.SubgovernmentalClassification.Id,
                        MercedesSubgovernmentalClassification = i.SubgovernmentalClassification.MercedesSubgovernmentalClassification,
                        DescriptionShort = i.SubgovernmentalClassification.DescriptionShort,
                        DescriptionLong = i.SubgovernmentalClassification.DescriptionLong
                    },
                    MercedesCuitClassification = i.MercedesCuitClassification,
                    CuitClassificationId = i.CuitClassificationId,
                    CuitClassification = i.CuitClassification == null ? null : new CuitClassificationDto
                    {
                        Id = i.CuitClassification.Id,
                        MercedesCuitClassification = i.CuitClassification.MercedesCuitClassification,
                        DescriptionShort = i.CuitClassification.DescriptionShort,
                        DescriptionLong = i.CuitClassification.DescriptionLong
                    },
                    Aperture1 = i.Aperture1,
                    ApertureOneId = i.ApertureOneId,
                    ApertureOne = i.ApertureOne == null ? null : new ApertureOneDto
                    {
                        Id = i.ApertureOne.Id,
                        MercedesApertureOne = i.ApertureOne.MercedesApertureOne,
                        DescriptionShort = i.ApertureOne.DescriptionShort,
                        DescriptionLong = i.ApertureOne.DescriptionLong
                    },
                    Aperture2 = i.Aperture2,
                    ApertureTwoId = i.ApertureTwoId,
                    ApertureTwo = i.ApertureTwo == null ? null : new ApertureTwoDto
                    {
                        Id = i.ApertureTwo.Id,
                        MercedesApertureTwo = i.ApertureTwo.MercedesApertureTwo,
                        DescriptionShort = i.ApertureTwo.DescriptionShort,
                        DescriptionLong = i.ApertureTwo.DescriptionLong
                    },
                    MercedesLogisticClassification = i.MercedesLogisticClassification,
                    LogisticClassificationId = i.LogisticClassificationId,
                    LogisticClassification = i.LogisticClassification == null ? null : new LogisticClassificationDto
                    {
                        Id = i.LogisticClassification.Id,
                        MercedesLogisticClassification = i.LogisticClassification.MercedesLogisticClassification,
                        DescriptionShort = i.LogisticClassification.DescriptionShort,
                        DescriptionLong = i.LogisticClassification.DescriptionLong
                    },
                    MercedesEstimatedTurnover = i.MercedesEstimatedTurnover,
                    EstimatedTurnoverId = i.EstimatedTurnoverId,
                    EstimatedTurnover = i.EstimatedTurnover == null ? null : new EstimatedTurnoverDto
                    {
                        Id = i.EstimatedTurnover.Id,
                        MercedesEstimatedTurnover = i.EstimatedTurnover.MercedesEstimatedTurnover,
                        DescriptionShort = i.EstimatedTurnover.DescriptionShort,
                        DescriptionLong = i.EstimatedTurnover.DescriptionLong
                    },
                    SocialContractDate = i.SocialContractDate,
                    EmployeesInfo = i.EmployeesInfo,
                    Quantity = i.Quantity,
                    FileId = i.FileId
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<OdsOwnerClassificationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<OdsOwnerClassificationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<OdsOwnerClassification> Create(OdsOwnerClassificationDto dto)
        {
            try
            {
                var entity = Context.OdsOwnerClassifications.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status400BadRequest, $"Patenting Clasificación Titular ya existe.");
                entity = _mapper.Map<OdsOwnerClassification>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<OdsOwnerClassification> Update(OdsOwnerClassificationDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.OdsOwnerClassifications.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status400BadRequest, $"Id de Patenting Clasificación Titular no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<OdsOwnerClassification>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
