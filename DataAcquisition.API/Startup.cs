using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Repository.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Repository.Repositories;
using DataAcquisition.Service.Services;
using Microsoft.EntityFrameworkCore;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Interface.LicenseManager;

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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IFacilityService, FacilityService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWorkstationService, WorkstationService>();

            services.AddDbContext<AppDbContext>(
                options =>
                {
                    options.UseSqlServer(Configuration["ConnectionStrings:SqlConnectionString"], o =>
                    {
                        o.MigrationsAssembly("DataAcquisition.DataAccessEF");
                    });
                });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
