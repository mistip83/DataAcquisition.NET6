using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.Service.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICalibrationManager, CalibrationManager.CalibrationManager>();
            services.AddScoped<IExperimentManager, ExperimentManager.ExperimentManager>();
            return services;
        }
    }
}