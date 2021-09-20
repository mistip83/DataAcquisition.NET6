using DataAcquisition.Core.Interfaces;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Repository.Repositories;
using DataAcquisition.Repository.UnitOfWork;
using DataAcquisition.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.API.Dependencies
{
    public static class DependencyConfig
    {
        public static IServiceCollection RegisterCommonDependencies(this IServiceCollection container)
        {
            container.AddAutoMapper(typeof(Startup));
            container.AddScoped<IUnitOfWork, UnitOfWork>();
            container.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            container.AddScoped(typeof(IService<>), typeof(Service<>));
            container.AddScoped<ICompanyService, CompanyService>();
            container.AddScoped<IFacilityService, FacilityService>();
            container.AddScoped<IUserService, UserService>();
            container.AddScoped<IWorkstationService, WorkstationService>();
            container.AddScoped<IDeviceService, DeviceService>();
            container.AddScoped<IAppConfiguration, AppConfiguration>();
            container.AddScoped<ICalibrationService, CalibrationService>();

            return container;
        }
    }
}