using DataAcquisition.API.Dependencies;
using DataAcquisition.API.Extensions;
using DataAcquisition.CalibrationManager.Dependencies;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Service.Dependencies;
using DataAcquisition.ExperimentManager.Dependencies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace DataAcquisition.API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.RegisterCommonDependencies();
        services.RegisterServiceDependencies();
        services.RegisterCalibrationDependencies();
        services.RegisterExperimentManagerDependencies();

        services.AddDbContext<AppDbContext>(
            options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConnectionString"], o =>
                {
                    o.MigrationsAssembly("DataAcquisition.DataAccessEF");
                });
            });

        services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        // Cross-origin resource sharing is a mechanism that allows restricted resources on a web page
        // to be requested from another domain outside the domain from which the first resource was served.
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });

        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "DataAcquisition.API", Version = "v1" });
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DataAcquisition.API v1"));
        }

        app.UseCustomGlobalErrorHandler();

        app.UseHttpsRedirection();

        app.UseRouting();

        // The call to UseCors must be placed after UseRouting, but before UseAuthorization.
        // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0#middleware-order
        app.UseCors("CorsPolicy");

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}