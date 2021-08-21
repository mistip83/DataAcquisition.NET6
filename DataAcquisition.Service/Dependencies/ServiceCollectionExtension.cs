using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Interface.ConnectionManager;
using DataAcquisition.Interface.DeviceManager;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.Service.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICalibrationManager, CalibrationManager.CalibrationManager>();
            services.AddScoped<IConnectionManager, ConnectionManager.ConnectionManager>();
            services.AddScoped<IDeviceManager, DeviceManager.DeviceManager>();
            return services;
        }
    }
}