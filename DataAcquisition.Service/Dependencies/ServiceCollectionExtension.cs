using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Repository.Repositories;
using DataAcquisition.Repository.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.Service.Dependencies;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterServiceDependencies(this IServiceCollection container)
    {
        container.AddScoped<ICalibrationManager, CalibrationManager.CalibrationManager>();
        container.AddScoped<IExperimentManager, ExperimentManager.ExperimentManager>();
        container.AddScoped<IUnitOfWork, UnitOfWork>();
        container.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        return container;
    }
}