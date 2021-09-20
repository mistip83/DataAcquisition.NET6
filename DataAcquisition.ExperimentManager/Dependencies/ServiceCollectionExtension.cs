﻿using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.DeviceLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.ExperimentManager.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterExperimentManagerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IConnectionManager, ConnectionManager.ConnectionManager>();
            services.AddScoped<IDeviceLibraryManager, DeviceLibraryManager>();
            return services;
        }
    }
}