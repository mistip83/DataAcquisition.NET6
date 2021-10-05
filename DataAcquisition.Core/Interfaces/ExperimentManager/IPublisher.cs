using System;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IPublisher
    {
        event EventHandler<IExperimentProcessedEvent> OnExperimentProcessed;
        void Notify(ExperimentState state);
    }
}