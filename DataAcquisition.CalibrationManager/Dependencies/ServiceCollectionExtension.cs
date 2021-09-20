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
        public static IServiceCollection RegisterCalibrationDependencies(this IServiceCollection container)
        {
            container.AddScoped<IConnectionManager, ConnectionManager.ConnectionManager>();
            container.AddScoped<IDeviceLibraryManager, DeviceLibraryManager>();
            container.AddScoped<IScannerManager, ScannerManager>();

            return container;
        }
    }
}