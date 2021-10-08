using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IExperimentProcessedEvent
    {
        /// <summary>
        /// Current experiment status to notify subscribers
        /// </summary>
        ExperimentState ExperimentState { get; set; }
    }
}