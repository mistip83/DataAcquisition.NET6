using DataAcquisition.Core.Interfaces.DeviceManager;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.Service.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDeviceManager, DeviceManager.DeviceManager>();
            return services;
        }
    }
}