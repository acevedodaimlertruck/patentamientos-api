using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Application.Dailies;
using LCH.MercedesBenz.Api.Models.Application.EventFiles;
using LCH.MercedesBenz.Api.Models.Application.Files;
using LCH.MercedesBenz.Api.Models.Application.FileTypes;
using LCH.MercedesBenz.Api.Models.Application.Monthlies;
using LCH.MercedesBenz.Api.Models.Application.Permissions;
using LCH.MercedesBenz.Api.Models.Application.RolePermissions;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using LCH.MercedesBenz.Api.Models.Application.Wholesales;
using LCH.MercedesBenz.Api.Models.Application.SecurityParameters;
using LCH.MercedesBenz.Api.Models.Application.Users;
using LCH.MercedesBenz.Api.Models.Recolector;
using LCH.MercedesBenz.Api.Models.Recolector.Entidades;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios;
using LCH.MercedesBenz.Api.Models.Recolector.Personas;
using LCH.MercedesBenz.Api.Models.Recolector.PreguntaSecciones;
using LCH.MercedesBenz.Api.Models.Recolector.Respuestas;
using LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos;
using LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas;
using LCH.MercedesBenz.Api.Models.Universal;
using LCH.MercedesBenz.Api.Models.Universal.Individuos;
using LCH.MercedesBenz.Api.Models.Universal.Sistemas;
using LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios;
using LCH.MercedesBenz.Api.Models.Universal.UsuarioOrganizaciones;
using LCH.MercedesBenz.Api.Models.Universal.Usuarios;
using LCH.MercedesBenz.Api.Models.Universal.UsuarioSistemas;
using LCH.MercedesBenz.Api.Services.Application.Roles;
using LCH.MercedesBenz.Api.Services.Application.Users;
using LCH.MercedesBenz.Api.Services.Azure;
using LCH.MercedesBenz.Api.Services.HttpContext;
using LCH.MercedesBenz.Api.Services.Recolector.Formularios;
using LCH.MercedesBenz.Api.Services.Recolector.Visitas;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.Provinces;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.Factories;
using LCH.MercedesBenz.Api.Models.Application.Owners;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.Terminals;
using LCH.MercedesBenz.Api.Models.Application.TMMVS;
using LCH.MercedesBenz.Api.Models.Application.OFMM;
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
using LCH.MercedesBenz.Api.Models.Application.Rules;
using LCH.MercedesBenz.Api.Models.Application.Grados;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
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

namespace LCH.MercedesBenz.Api
{
    public static class ProgramExtensions
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(ApplicationDbContext)),
                    options =>
                    {
                        options.EnableRetryOnFailure();
                        options.CommandTimeout(15 * 60);
                        options.UseNetTopologySuite();
                    }));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseNpgsql(configuration.GetConnectionString(nameof(ApplicationDbContext)),
            //        options =>
            //        {
            //            options.CommandTimeout(6 * 60);
            //            options.UseNetTopologySuite();
            //        }));

            services.AddDbContext<RecolectorDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(RecolectorDbContext)),
                    options =>
                    {
                        options.EnableRetryOnFailure();
                        options.CommandTimeout(6 * 60);
                        options.UseNetTopologySuite();
                    }));

            services.AddDbContext<UniversalDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(UniversalDbContext)),
                    options =>
                    {
                        options.EnableRetryOnFailure();
                        options.CommandTimeout(6 * 60);
                        options.UseNetTopologySuite();
                    }));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            // Application repositories
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IPermissionRepository), typeof(PermissionRepository));
            services.AddScoped(typeof(IRolePermissionRepository), typeof(RolePermissionRepository));
            services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IFileRepository), typeof(FileRepository));
            services.AddScoped(typeof(ICatRuleRepository), typeof(CatRuleRepository));
            services.AddScoped(typeof(IEventFileRepository), typeof(EventFileRepository));
            services.AddScoped(typeof(IFileTypeRepository), typeof(FileTypeRepository));
            services.AddScoped(typeof(IFuelTypeRepository), typeof(FuelTypeRepository));
            services.AddScoped(typeof(ICabinCFRepository), typeof(CabinCFRepository));
            services.AddScoped(typeof(IGearRepository), typeof(GearRepository));
            services.AddScoped(typeof(IAxleBaseRepository), typeof(AxleBaseRepository));
            services.AddScoped(typeof(IDailyRepository), typeof(DailyRepository));
            services.AddScoped(typeof(IMonthlyRepository), typeof(MonthlyRepository));
            services.AddScoped(typeof(IWholesaleRepository), typeof(WholesaleRepository));
            services.AddScoped(typeof(ISecurityParameterRepository), typeof(SecurityParameterRepository));
            services.AddScoped(typeof(IVehicleTypeRepository), typeof(VehicleTypeRepository));
            services.AddScoped(typeof(IBrandRepository), typeof(BrandRepository));
            services.AddScoped(typeof(IProvinceRepository), typeof(ProvinceRepository));
            services.AddScoped(typeof(ICarModelRepository), typeof(CarModelRepository));
            services.AddScoped(typeof(IFactoryRepository), typeof(FactoryRepository));
            services.AddScoped(typeof(IOwnerRepository), typeof(OwnerRepository));
            services.AddScoped(typeof(IPatentingRepository), typeof(PatentingRepository));
            services.AddScoped(typeof(ITerminalRepository), typeof(TerminalRepository));
            services.AddScoped(typeof(IOfmmRepository), typeof(OfmmRepository));
            services.AddScoped(typeof(ITMMVRepository), typeof(TMMVRepository));
            services.AddScoped(typeof(IClosureRepository), typeof(ClosureRepository));
            services.AddScoped(typeof(IDepartmentRepository), typeof(DepartmentRepository));
            services.AddScoped(typeof(ILocationRepository), typeof(LocationRepository));
            services.AddScoped(typeof(IRegSecRepository), typeof(RegSecRepository));
            services.AddScoped(typeof(IWholesaleVersionRepository), typeof(WholesaleVersionRepository));
            services.AddScoped(typeof(IPatentingVersionRepository), typeof(PatentingVersionRepository));
            services.AddScoped(typeof(ICat_InternalVersionRepository), typeof(Cat_InternalVersionRepository));
            services.AddScoped(typeof(IInternalVersionRepository), typeof(InternalVersionRepository));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddScoped(typeof(ISegmentRepository), typeof(SegmentRepository));
            services.AddScoped(typeof(IInternalVersionSegmentationRepository), typeof(InternalVersionSegmentationRepository));
            services.AddScoped(typeof(IKeyVersionRepository), typeof(KeyVersionRepository));
            services.AddScoped(typeof(ISegmentationPlateRepository), typeof(SegmentationPlateRepository));
            services.AddScoped(typeof(IRuleRepository), typeof(RuleRepository));
            services.AddScoped(typeof(IGradoRepository), typeof(GradoRepository));
            services.AddScoped(typeof(IOdsWholesaleRepository), typeof(OdsWholesaleRepository));
            services.AddScoped(typeof(ISpecialSaleRepository), typeof(SpecialSaleRepository));
            services.AddScoped(typeof(IGovernmentalClassificationRepository), typeof(GovernmentalClassificationRepository));
            services.AddScoped(typeof(ILegalEntityRepository), typeof(LegalEntityRepository));
            services.AddScoped(typeof(ISubgovernmentalClassificationRepository), typeof(SubgovernmentalClassificationRepository));
            services.AddScoped(typeof(IEstimatedTurnoverRepository), typeof(EstimatedTurnoverRepository));
            services.AddScoped(typeof(ICuitClassificationRepository), typeof(CuitClassificationRepository));
            services.AddScoped(typeof(IApertureOneRepository), typeof(ApertureOneRepository));
            services.AddScoped(typeof(IApertureTwoRepository), typeof(ApertureTwoRepository));
            services.AddScoped(typeof(ILogisticClassificationRepository), typeof(LogisticClassificationRepository));
            services.AddScoped(typeof(IOdsOwnerClassificationRepository), typeof(OdsOwnerClassificationRepository));
            services.AddScoped(typeof(IBodyworkRepository), typeof(BodyworkRepository));
            services.AddScoped(typeof(IBodyStyleRepository), typeof(BodyStyleRepository));
            services.AddScoped(typeof(ISubsegmentRepository), typeof(SubsegmentRepository));
            services.AddScoped(typeof(IUsageRepository), typeof(UsageRepository));
            services.AddScoped(typeof(ITractionRepository), typeof(TractionRepository));
            services.AddScoped(typeof(IPowerRepository), typeof(PowerRepository));
            services.AddScoped(typeof(IHistoricalRepository), typeof(HistoricalRepository));
            services.AddScoped(typeof(IPatentingVersionRepository), typeof(PatentingVersionRepository));
            services.AddScoped(typeof(IWholesaleVersionRepository), typeof(WholesaleVersionRepository));
            services.AddScoped(typeof(IWheelBaseRepository), typeof(WheelBaseRepository));
            services.AddScoped(typeof(IDoorRepository), typeof(DoorRepository));
            services.AddScoped(typeof(ISourceRepository), typeof(SourceRepository));
            services.AddScoped(typeof(IMCGTotalMktRepository), typeof(MCGTotalMktRepository));
            services.AddScoped(typeof(IMotorDTRepository), typeof(MotorDTRepository));
            services.AddScoped(typeof(IApertureThreeRepository), typeof(ApertureThreeRepository));
            services.AddScoped(typeof(IApertureFourRepository), typeof(ApertureFourRepository));
            services.AddScoped(typeof(ICJDCompetitiveRepository), typeof(CJDCompetitiveRepository));
            services.AddScoped(typeof(IPBTRepository), typeof(PBTRepository));
            services.AddScoped(typeof(IEngineCapacityRepository), typeof(EngineCapacityRepository));
            services.AddScoped(typeof(ICabinSDRepository), typeof(CabinSDRepository));
            services.AddScoped(typeof(ICompetitiveCJDRepository), typeof(CompetitiveCJDRepository));
            services.AddScoped(typeof(IConfigurationRepository), typeof(ConfigurationRepository));
            services.AddScoped(typeof(IAltBodystRepository), typeof(AltBodystRepository));
            services.AddScoped(typeof(IAltCategRepository), typeof(AltCategRepository));
            services.AddScoped(typeof(IAltSegmRepository), typeof(AltSegmRepository));
            services.AddScoped(typeof(IAMGCompSetRepository), typeof(AMGCompSetRepository));
            services.AddScoped(typeof(IPBTTNRepository), typeof(PBTTNRepository));
            services.AddScoped(typeof(INIRepository), typeof(NIRepository));
            services.AddScoped(typeof(IRelevMBRepository), typeof(RelevMBRepository));
            services.AddScoped(typeof(ISegmentationAux1Repository), typeof(SegmentationAux1Repository));
            services.AddScoped(typeof(ISSegmRepository), typeof(SSegmRepository));
            services.AddScoped(typeof(IGroupRepository), typeof(GroupRepository));


            // Recolector repositories
            services.AddScoped(typeof(IBaseRecolectorRepository<>), typeof(BaseRecolectorRepository<>));
            services.AddScoped(typeof(IEntidadRepository), typeof(EntidadRepository));
            services.AddScoped(typeof(IFormularioRepository), typeof(FormularioRepository));
            services.AddScoped(typeof(IPersonaRepository), typeof(PersonaRepository));
            services.AddScoped(typeof(IPreguntaSeccionRepository), typeof(PreguntaSeccionRepository));
            services.AddScoped(typeof(IRespuestaRepository), typeof(RespuestaRepository));
            services.AddScoped(typeof(ISaltoObjetoRepository), typeof(SaltoObjetoRepository));
            services.AddScoped(typeof(IValidacionComplejaRepository), typeof(ValidacionComplejaRepository));
            services.AddScoped(typeof(IVersionRepository), typeof(VersionRepository));
            services.AddScoped(typeof(IVisitaRepository), typeof(VisitaRepository));

            // Universal repositories
            services.AddScoped(typeof(IBaseUniversalRepository<>), typeof(BaseUniversalRepository<>));
            services.AddScoped(typeof(IIndividuoRepository), typeof(IndividuoRepository));
            services.AddScoped(typeof(ISistemaRepository), typeof(SistemaRepository));
            services.AddScoped(typeof(ITipoUsuarioRepository), typeof(TipoUsuarioRepository));
            services.AddScoped(typeof(IUsuarioOrganizacionRepository), typeof(UsuarioOrganizacionRepository));
            services.AddScoped(typeof(IUsuarioRepository), typeof(UsuarioRepository));
            services.AddScoped(typeof(IUsuarioSistemaRepository), typeof(UsuarioSistemaRepository));
        }

        public static void AddServices(this IServiceCollection services)
        {
            // Application services
            services.AddScoped(typeof(IRoleService), typeof(RoleService));
            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(AzureService), typeof(AzureService));

            // Recolector services
            services.AddScoped(typeof(IFormularioService), typeof(FormularioService));
            services.AddScoped(typeof(IVisitaService), typeof(VisitaService));

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IHttpContextService, HttpContextService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                // Application profiles
                mc.AddProfile(new AxleBaseProfile());
                mc.AddProfile(new RoleProfile());
                mc.AddProfile(new UserProfile());
                mc.AddProfile(new BrandProfile());
                mc.AddProfile(new CarModelProfile());
                mc.AddProfile(new FactoryProfile());
                mc.AddProfile(new FuelTypeProfile());
                mc.AddProfile(new CabinCFProfile());
                mc.AddProfile(new GearProfile());
                mc.AddProfile(new CatRuleProfile());
                mc.AddProfile(new OwnerProfile());
                mc.AddProfile(new TerminalProfile());
                mc.AddProfile(new VehicleTypeProfile());
                mc.AddProfile(new PatentingProfile());
                mc.AddProfile(new TMMVProfile());
                mc.AddProfile(new OfmmProfile());
                mc.AddProfile(new ClosureProfile());
                mc.AddProfile(new InternalVersionProfile());
                mc.AddProfile(new CategoryProfile());
                mc.AddProfile(new SegmentProfile());
                mc.AddProfile(new InternalVersionSegmentationProfile());
                mc.AddProfile(new KeyVersionProfile());
                mc.AddProfile(new SegmentationPlateProfile());
                mc.AddProfile(new GradoProfile());
                mc.AddProfile(new OdsWholesaleProfile());
                mc.AddProfile(new GovernmentalClassificationProfile());
                mc.AddProfile(new LegalEntityProfile());
                mc.AddProfile(new SubgovernmentalClassificationProfile());
                mc.AddProfile(new EstimatedTurnoverProfile());
                mc.AddProfile(new CuitClassificationProfile());
                mc.AddProfile(new ApertureOneProfile());
                mc.AddProfile(new ApertureTwoProfile());
                mc.AddProfile(new LogisticClassificationProfile());
                mc.AddProfile(new OdsOwnerClassificationProfile());
                mc.AddProfile(new BodyworkProfile());
                mc.AddProfile(new BodyStyleProfile());
                mc.AddProfile(new SubsegmentProfile());
                mc.AddProfile(new UsageProfile());
                mc.AddProfile(new TractionProfile());
                mc.AddProfile(new PowerProfile());
                mc.AddProfile(new PatentingVersionProfile());
                mc.AddProfile(new WholesaleVersionProfile());
                mc.AddProfile(new Cat_InternalVersionProfile());                
                mc.AddProfile(new WheelBaseProfile());
                mc.AddProfile(new DoorProfile());
                mc.AddProfile(new SourceProfile());
                mc.AddProfile(new MCGTotalMktProfile());
                mc.AddProfile(new MotorDTProfile());
                mc.AddProfile(new ApertureThreeProfile());
                mc.AddProfile(new ApertureFourProfile());
                mc.AddProfile(new CJDCompetitiveProfile());
                mc.AddProfile(new PBTProfile());
                mc.AddProfile(new EngineCapacityProfile());
                mc.AddProfile(new CabinSDProfile());
                mc.AddProfile(new CompetitiveCJDProfile());
                mc.AddProfile(new AltBodystProfile());
                mc.AddProfile(new AltCategProfile());
                mc.AddProfile(new AltSegmProfile());
                mc.AddProfile(new AMGCompSetProfile());
                mc.AddProfile(new PBTTNProfile());
                mc.AddProfile(new NIProfile());
                mc.AddProfile(new RelevMBProfile());
                mc.AddProfile(new SegmentationAux1Profile());
                mc.AddProfile(new SSegmProfile());
                mc.AddProfile(new GroupProfile());
                // Recolector profiles

                // Universal profiles
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddExternalAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication("Bearer").AddJwtBearer("Bearer",
                options =>
                {
                    options.Authority = configuration["Authentication:External:Authority"];
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new
                        TokenValidationParameters
                    {
                        ValidateAudience = false
                    };
                });
        }

        public static void AddPolicies(this IServiceCollection services, IConfiguration configuration)
        {
            var scope = configuration["Authentication:External:Scope"];
            services.AddAuthorization(options =>
                options.AddPolicy("LchIdentityServer4Policy",
                    policy => policy.RequireClaim("scope", scope)));

            //services.AddAuthorization(options =>
            //    options.AddPolicy("Customer",
            //        policy => policy.RequireClaim("scope", "APICustomer")));
        }

        public static void AddInternalAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var validIssuers = new List<string>()
            {
                configuration["Authentication:Internal:Issuer"].Replace("http://", "https://"),
                configuration["Authentication:Internal:Issuer"].Replace("https://", "http://"),
            };

            var validAudiences = new List<string>()
            {
                configuration["Authentication:Internal:Audience"].Replace("http://", "https://"),
                configuration["Authentication:Internal:Audience"].Replace("https://", "http://")
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:Internal:SecretKey"])),
                    ValidateIssuer = false, // TODO set to true on Production
                    ValidateAudience = false, // TODO set to true on Production
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidAudiences = validAudiences,
                    ValidIssuers = validIssuers,
                };
            });
        }
    }
}
