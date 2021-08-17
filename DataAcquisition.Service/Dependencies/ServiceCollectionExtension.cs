using DataAcquisition.Interface.CalibrationManager;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.Service.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICalibrationManager, CalibrationManager.CalibrationManager>();
            return services;
        }
    }
}