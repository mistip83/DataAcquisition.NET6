using System;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.ExperimentManager.Events;

namespace DataAcquisition.ExperimentManager.Publishers
{
    public class ExperimentStatePublisher : IPublisher
    {
        public event EventHandler<IExperimentProcessedEvent> OnExperimentProcessed;

        public void Notify(ExperimentState state)
        {
            OnExperimentProcessed?.Invoke(this, new ExperimentProcessedEventArgs(state));

            if (OnExperimentProcessed != null)
            {
                OnExperimentProcessed(this, new ExperimentProcessedEventArgs(state));
            }
        }
    }
}