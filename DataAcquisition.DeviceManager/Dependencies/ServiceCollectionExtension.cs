using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.DeviceLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.DeviceManager.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterDeviceManagerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICalibrationManager, CalibrationManager.CalibrationManager>();
            services.AddScoped<IConnectionManager, ConnectionManager.ConnectionManager>();
            services.AddScoped<IDeviceLibraryManager, DeviceLibraryManager>();
            return services;
        }
    }
}