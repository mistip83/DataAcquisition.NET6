using DataAcquisition.API.Dependencies;
using DataAcquisition.API.Extensions;
using DataAcquisition.CalibrationManager.Dependencies;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.DeviceManager.Dependencies;
using DataAcquisition.Service.Dependencies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;


namespace DataAcquisition.API
{
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
            services.RegisterDeviceManagerDependencies();

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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCustomErrorHandler();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
