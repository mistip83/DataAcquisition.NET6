using DataAcquisition.Core.Interfaces.ScannerManager;
using DataAcquisition.Scanner;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.CalibrationManager.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterCalibrationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IScannerManager, ScannerManager>();
            return services;
        }
    }
}