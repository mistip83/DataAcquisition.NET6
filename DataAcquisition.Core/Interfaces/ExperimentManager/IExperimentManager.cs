using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.Core.Interfaces.ExperimentManager;

public interface IExperimentManager
{
    Task ExperimentOrchestrator(AcquisitionConfig config);
}