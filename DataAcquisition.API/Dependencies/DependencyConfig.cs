using DataAcquisition.Core.Interfaces.Configuration;
using DataAcquisition.Core.Interfaces.DataAcquisition;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.API.Dependencies
{
    public static class DependencyConfig
    {
        public static IServiceCollection RegisterCommonDependencies(this IServiceCollection container)
        {
            container.AddAutoMapper(typeof(Startup));
            container.AddScoped(typeof(IService<>), typeof(Service<>));
            container.AddScoped<ICompanyService, CompanyService>();
            container.AddScoped<IFacilityService, FacilityService>();
            container.AddScoped<IUserService, UserService>();
            container.AddScoped<IWorkstationService, WorkstationService>();
            container.AddScoped<IDeviceService, DeviceService>();
            container.AddScoped<IAppConfiguration, AppConfiguration>();
            container.AddScoped<ICalibrationService, CalibrationService>();
            container.AddScoped<IExperimentService, ExperimentService>();
            container.AddScoped<IDataAcquisitionService, DataAcquisitionService>();

            return container;
        }
    }
}