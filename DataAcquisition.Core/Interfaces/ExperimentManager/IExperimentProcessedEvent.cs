using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IExperimentProcessedEvent
    {
        ExperimentState ExperimentState { get; set; }
    }
}