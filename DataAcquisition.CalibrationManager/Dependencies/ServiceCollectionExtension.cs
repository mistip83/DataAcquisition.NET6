using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.ScannerManager;
using DataAcquisition.DeviceLibrary;
using DataAcquisition.Scanner;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.CalibrationManager.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterCalibrationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IConnectionManager, ConnectionManager.ConnectionManager>();
            services.AddScoped<IDeviceLibraryManager, DeviceLibraryManager>();
            services.AddScoped<IScannerManager, ScannerManager>();
            return services;
        }
    }
}