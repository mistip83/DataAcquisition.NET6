using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.DeviceLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.DeviceManager.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterDeviceManagerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDeviceLibraryManager, DeviceLibraryManager>();
            return services;
        }
    }
}