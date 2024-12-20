using LCH.MercedesBenz.Api;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContexts(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy",
        policy =>
        {
            policy.WithOrigins(
                builder.Configuration["AllowedOrigins:Localhost4200"],
                builder.Configuration["AllowedOrigins:Localhost8081"],
                builder.Configuration["AllowedOrigins:EduOficina"],
                builder.Configuration["AllowedOrigins:EduCasa"],
                builder.Configuration["AllowedOrigins:MartinPC"],
                builder.Configuration["AllowedOrigins:PCFRANCO"],
                builder.Configuration["AllowedOrigins:Staging"],
                builder.Configuration["AllowedOrigins:Production"]
            ).AllowAnyHeader().AllowAnyMethod();
        });
});

builder.Services.AddControllers()
     .AddNewtonsoftJson(o =>
     {
         o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
     });
//.AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    options.JsonSerializerOptions.WriteIndented = true;
//});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMemoryCache();

// External authentication
//builder.Services.AddExternalAuthentication(builder.Configuration);
//builder.Services.AddPolicies(builder.Configuration);

// Internal authentication
builder.Services.AddInternalAuthentication(builder.Configuration);

builder.Services.AddRepositories();

builder.Services.AddServices();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddSwaggerGen(action =>
{
    action.SwaggerDoc("v1", new OpenApiInfo { Title = "Mercedes Benz API .NET 7 API", Version = builder.Configuration["Version:Number"] });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        var dotPrefix = string.IsNullOrWhiteSpace(options.RoutePrefix) ? "." : "..";
        options.SwaggerEndpoint($"{dotPrefix}/swagger/v1/swagger.json", $"Mercedes Benz API .NET 7 API {builder.Configuration["Version:Number"]} ({builder.Configuration["Version:Date"]})");
    });
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
