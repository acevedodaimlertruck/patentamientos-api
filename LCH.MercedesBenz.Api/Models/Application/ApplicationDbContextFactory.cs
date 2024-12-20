using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var path = "appsettings.json";
#if DEBUG
            path = "appsettings.Development.json";
#endif
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile(path, optional: false)
                .Build();
            var connectionString = configuration.GetConnectionString(nameof(ApplicationDbContext));
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            // Comment or uncomment next block if you are using SQL Server or PostgreSQL
            optionsBuilder.UseSqlServer(connectionString,
                x =>
                {
                    x.EnableRetryOnFailure();
                    x.CommandTimeout(15 * 60);
                    x.UseNetTopologySuite();
                });
            //optionsBuilder.UseNpgsql(connectionString,
            //    x =>
            //    {
            //        x.CommandTimeout(6 * 60);
            //        x.UseNetTopologySuite();
            //    });
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
