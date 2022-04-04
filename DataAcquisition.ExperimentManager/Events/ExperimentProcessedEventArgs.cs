using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ExperimentManager;

namespace DataAcquisition.ExperimentManager.Events;

public class ExperimentProcessedEventArgs : EventArgs, IExperimentProcessedEvent
{
    public ExperimentState ExperimentState { get; set; }

    public ExperimentProcessedEventArgs(ExperimentState experimentState)
    {
        ExperimentState = experimentState;
    }
}