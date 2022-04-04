using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services;

public interface IExperimentService : IService<Experiment>
{
    /// <summary>
    /// Create a new experiment and start data acquisition
    /// </summary>
    /// <param name="config"></param>
    public Task StartNewExperiment(AcquisitionConfig config);
}