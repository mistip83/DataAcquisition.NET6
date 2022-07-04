using DataAcquisition.Core.Interfaces.Configuration;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Service;

namespace DataAcquisition.API.Dependencies;

public static class DependencyConfig
{
    public static IServiceCollection RegisterCommonDependencies(this IServiceCollection container)
    {
        container.AddScoped(typeof(IService<>), typeof(Service<>));
        container.AddScoped<ICompanyService, CompanyService>();
        container.AddScoped<IFacilityService, FacilityService>();
        container.AddScoped<IUserService, UserService>();
        container.AddScoped<IWorkstationService, WorkstationService>();
        container.AddScoped<IDeviceService, DeviceService>();
        container.AddScoped<IAppConfiguration, AppConfiguration>();
        container.AddScoped<ICalibrationService, CalibrationService>();
        container.AddScoped<IExperimentService, ExperimentService>();
        container.AddScoped<IAcquisitionService, AcquisitionService>();

        return container;
    }
}