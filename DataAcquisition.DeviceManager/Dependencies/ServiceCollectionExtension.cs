using DataAcquisition.DeviceLibrary;
using DataAcquisition.Interface.DeviceLibrary;
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