using LCH.MercedesBenz.Api.Models.Application.SecurityParameters;
using LCH.MercedesBenz.Api.Models.Application.Dailies;
using LCH.MercedesBenz.Api.Models.Application.EventFiles;
using LCH.MercedesBenz.Api.Models.Application.FileTypes;
using LCH.MercedesBenz.Api.Models.Application.Monthlies;
using LCH.MercedesBenz.Api.Models.Application.Permissions;
using LCH.MercedesBenz.Api.Models.Application.RolePermissions;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using LCH.MercedesBenz.Api.Models.Application.Wholesales;
using LCH.MercedesBenz.Api.Models.Application.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.DependencyModel;
using System.Reflection;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.Provinces;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.Factories;
using LCH.MercedesBenz.Api.Models.Application.Owners;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Terminals;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes;
using LCH.MercedesBenz.Api.Models.Application.Rules;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas;
using LCH.MercedesBenz.Api.Models.Application.OFMM;
using LCH.MercedesBenz.Api.Models.Application.FechaCierres;
using LCH.MercedesBenz.Api.Models.Application.RulePatentings;
using LCH.MercedesBenz.Api.Models.Application.TMMVS;
using LCH.MercedesBenz.Api.Models.Application.Closures;
using LCH.MercedesBenz.Api.Models.Application.Departments;
using LCH.MercedesBenz.Api.Models.Application.Locations;
using LCH.MercedesBenz.Api.Models.Application.RegSecs;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.Categories;
using LCH.MercedesBenz.Api.Models.Application.Segments;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;
using LCH.MercedesBenz.Api.Models.Application.Grados;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
using LCH.MercedesBenz.Api.Models.Application.RuleOdsWholesales;
using LCH.MercedesBenz.Api.Models.Application.SpecialSales;
using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications;
using LCH.MercedesBenz.Api.Models.Application.LegalEntities;
using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications;
using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers;
using LCH.MercedesBenz.Api.Models.Application.CuitClassifications;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo;
using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications;
using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications;
using LCH.MercedesBenz.Api.Models.Application.Bodyworks;
using LCH.MercedesBenz.Api.Models.Application.BodyStyles;
using LCH.MercedesBenz.Api.Models.Application.Subsegments;
using LCH.MercedesBenz.Api.Models.Application.Usages;
using LCH.MercedesBenz.Api.Models.Application.Tractions;
using LCH.MercedesBenz.Api.Models.Application.Powers;
using LCH.MercedesBenz.Api.Models.Application.Historicals;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;
using LCH.MercedesBenz.Api.Models.Application.WheelBases;
using LCH.MercedesBenz.Api.Models.Application.AxleBases;
using LCH.MercedesBenz.Api.Models.Application.Gears;
using LCH.MercedesBenz.Api.Models.Application.Doors;
using LCH.MercedesBenz.Api.Models.Application.Sources;
using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts;
using LCH.MercedesBenz.Api.Models.Application.MotorDTs;
using LCH.MercedesBenz.Api.Models.Application.ApertureThrees;
using LCH.MercedesBenz.Api.Models.Application.ApertureFours;
using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives;
using LCH.MercedesBenz.Api.Models.Application.PBTs;
using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys;
using LCH.MercedesBenz.Api.Models.Application.CabinCFs;
using LCH.MercedesBenz.Api.Models.Application.CabinSDs;
using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs;
using LCH.MercedesBenz.Api.Models.Application.Configurations;
using LCH.MercedesBenz.Api.Models.Application.AltBodysts;
using LCH.MercedesBenz.Api.Models.Application.AltCategs;
using LCH.MercedesBenz.Api.Models.Application.AltSegms;
using LCH.MercedesBenz.Api.Models.Application.AMGCompSets;
using LCH.MercedesBenz.Api.Models.Application.PBTTNs;
using LCH.MercedesBenz.Api.Models.Application.NIs;
using LCH.MercedesBenz.Api.Models.Application.RelevMBs;
using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s;
using LCH.MercedesBenz.Api.Models.Application.SSegms;
using LCH.MercedesBenz.Api.Models.Application.Groups;
using LCH.MercedesBenz.Api.Models.Application.CatRules;
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions;

namespace LCH.MercedesBenz.Api.Models.Application
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IHttpContextAccessor? _httpContextAccessor;

        static ApplicationDbContext()
        {
            // Uncomment next line if you are using PostgreSQL instead of SQL Server
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Uncomment next line if you are using PostgreSQL instead of SQL Server
            //modelBuilder.HasPostgresExtension("postgis");
            modelBuilder.ToVarchar();
            foreach (var type in GetEntityTypes())
            {
                var method = SetGlobalQueryMethod.MakeGenericMethod(type);
                method.Invoke(this, new object[] { modelBuilder });
            }
            modelBuilder.ApplyConfigurations();
            modelBuilder.Seed();
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<AxleBase> AxleBases { get; set; }
        public DbSet<CatRule> CatRules { get; set; }
        public DbSet<EventFile> EventFiles { get; set; }
        public DbSet<FileType> FileTypes { get; set; }
        public DbSet<CabinCF> CabinCFs { get; set; }
        public DbSet<CabinSD> CabinSDs { get; set; }
        public DbSet<CompetitiveCJD> CompetitiveCJDs { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<AltBodyst> AltBodysts { get; set; }
        public DbSet<AltCateg> AltCategs { get; set; }
        public DbSet<AltSegm> AltSegms { get; set; }
        public DbSet<AMGCompSet> AMGCompSets { get; set; }
        public DbSet<PBTTN> PBTTNs { get; set; }
        public DbSet<NI> NIs { get; set; }
        public DbSet<RelevMB> RelevMBs { get; set; }
        public DbSet<SegmentationAux1> SegmentationAux1s { get; set; }
        public DbSet<SSegm> SSegms { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<MCGTotalMkt> MCGTotalMkts { get; set; }
        public DbSet<MotorDT> MotorDTs { get; set; }
        public DbSet<ApertureThree> AperturesThree { get; set; }
        public DbSet<ApertureFour> AperturesFour { get; set; }
        public DbSet<CJDCompetitive> CJDCompetitives { get; set; }
        public DbSet<PBT> PBTs { get; set; }
        public DbSet<EngineCapacity> EngineCapacitys { get; set; }
        public DbSet<Daily> Dailies { get; set; }
        public DbSet<Monthly> Monthlies { get; set; }
        public DbSet<Wholesale> Wholesales { get; set; }
        public DbSet<WheelBase> WheelBases { get; set; }
        public DbSet<SecurityParameter> SecurityParameters { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Patenting> Patentings { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<RuleType> RuleTypes { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<RulePatenting> RulePatentings { get; set; }
        public DbSet<StatePatenta> StatePatentas { get; set; }
        public DbSet<Ofmm> Ofmms { get; set; }
        public DbSet<TMMV> TMMVs { get; set; }
        public DbSet<FechaCierre> FechaCierres { get; set; }
        public DbSet<Closure> Closures { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RegSec> RegSecs { get; set; }
        public DbSet<WholesaleVersion> WholesaleVersions { get; set; }
        public DbSet<PatentingVersion> PatentingVersions { get; set; }
        public DbSet<InternalVersion> InternalVersions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<InternalVersionSegmentation> InternalVersionSegmentations { get; set; }
        public DbSet<KeyVersion> KeyVersions { get; set; }
        public DbSet<SegmentationPlate> SegmentationPlates { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<OdsWholesale> OdsWholesales { get; set; }
        public DbSet<RuleOdsWholesale> RuleOdsWholesales { get; set; }
        public DbSet<SpecialSale> SpecialSales { get; set; }
        public DbSet<GovernmentalClassification> GovernmentalClassifications { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<SubgovernmentalClassification> SubgovernmentalClassifications { get; set; }
        public DbSet<EstimatedTurnover> EstimatedTurnovers { get; set; }
        public DbSet<CuitClassification> CuitClassifications { get; set; }
        public DbSet<ApertureOne> AperturesOne { get; set; }
        public DbSet<ApertureTwo> AperturesTwo { get; set; }
        public DbSet<LogisticClassification> LogisticClassifications { get; set; }
        public DbSet<OdsOwnerClassification> OdsOwnerClassifications { get; set; }
        public DbSet<Bodywork> Bodyworks { get; set; }
        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<Subsegment> Subsegments { get; set; }
        public DbSet<Usage> Usages { get; set; }
        public DbSet<Traction> Tractions { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Historical> Historicals { get; set; }
        public DbSet<Cat_InternalVersion> Cat_InternalVersions { get; set; }
        

        public override int SaveChanges()
        {
            var currentUser =
                string.IsNullOrEmpty(_httpContextAccessor?.HttpContext?.User?.Identity?.Name) ? "Anonymous" : _httpContextAccessor.HttpContext.User.Identity.Name;

            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Entity.CreatedAt = entry.Entity.CreatedAt ?? DateTime.UtcNow;
                        entry.Entity.CreatedBy = entry.Entity.CreatedBy ?? currentUser;
                    }
                    else
                    {
                        entry.Property(p => p.CreatedAt).IsModified = false;
                        entry.Property(p => p.CreatedBy).IsModified = false;
                    }

                    entry.Entity.UpdatedAt = entry.Entity.UpdatedAt ?? DateTime.UtcNow;
                    entry.Entity.UpdatedBy = entry.Entity.UpdatedBy ?? currentUser;
                }

                if (entry.State == EntityState.Deleted)
                {
                    SoftDelete(entry, this, entry.Entity.DeletedBy ?? currentUser);
                }
            }
            return base.SaveChanges();
        }

        public void SoftDelete(EntityEntry<BaseEntity> entry, ApplicationDbContext context, string? deletedBy)
        {
            var properties = entry.OriginalValues.Properties;
            foreach (var property in properties)
            {
                entry.Property(property.Name).CurrentValue = entry.OriginalValues[property.Name];
            }
            entry.Property("IsDeleted").CurrentValue = true;
            entry.Property("DeletedAt").CurrentValue = entry.Property("DeletedAt").CurrentValue ?? DateTime.UtcNow;
            entry.Property("DeletedBy").CurrentValue = entry.Property("DeletedBy").CurrentValue ?? deletedBy;
            entry.State = EntityState.Modified;
        }

        static readonly MethodInfo SetGlobalQueryMethod = typeof(ApplicationDbContext).GetMethods(BindingFlags.Public | BindingFlags.Instance)
                                                            .Single(t => t.IsGenericMethod && t.Name == "SetGlobalQuery");

        private static IEnumerable<Assembly> GetReferencingAssemblies()
        {
            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries;

            foreach (var library in dependencies)
            {
                try
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
                catch (FileNotFoundException)
                { }
            }
            return assemblies;
        }

        private static IList<Type>? _entityTypes;
        private static IList<Type> GetEntityTypes()
        {
            if (_entityTypes != null)
            {
                return _entityTypes.ToList();
            }

            _entityTypes = (from a in GetReferencingAssemblies()
                            from t in a.DefinedTypes
                            where t.BaseType == typeof(BaseEntity)
                            select t.AsType()).ToList();

            return _entityTypes;
        }

        public void SetGlobalQuery<T>(ModelBuilder builder) where T : BaseEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }
    }
}
