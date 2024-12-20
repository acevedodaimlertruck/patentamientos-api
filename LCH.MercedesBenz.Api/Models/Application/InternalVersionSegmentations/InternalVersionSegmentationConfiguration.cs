using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations
{
    public class InternalVersionSegmentationConfiguration : IEntityTypeConfiguration<InternalVersionSegmentation>
    {
        public void Configure(EntityTypeBuilder<InternalVersionSegmentation> builder)
        {
            builder
                .Property(b => b.AutoId)
                .UseIdentityColumn();

            builder
                .Property(b => b.AutoId)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder
               .Property(b => b.Cat_InternalVersionId)
               .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.BodyworkId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.BodyStyleId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.SubsegmentId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.UsageId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.TractionId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.PowerId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.AltBodystId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.DoorId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.SourceId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.MCGTotalMktId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.MotorDTId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.ApertureOneId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.ApertureTwoId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.ApertureThreeId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.ApertureFourId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.CJDCompetitiveId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.EngineCapacityId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.CabinCFId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.CabinSDId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.CompetitiveCJDId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.AltCategId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.AltSegmId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.AMGCompSetId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.PBTTNId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.NIId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.RelevMBId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.SegmentationAux1Id)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.SSegmId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.GroupId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.ConfigurationId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.WheelBaseId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.AxleBaseId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.GearId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.PBTId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.CatRuleId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));

            builder
                .Property(b => b.FuelTypeId)
                .HasDefaultValue(Guid.Parse("00000000-0000-0000-0000-000000000033"));


        }
    }
}
