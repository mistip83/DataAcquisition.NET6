using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    /// <summary>
    /// Subject interface to notify observers
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Register an observer to the subject
        /// </summary>
        /// <param name="observer"></param>
        void Attach(IObserver observer);

        /// <summary>
        /// Remove an observer from the subject
        /// </summary>
        /// <param name="observer"></param>
        void Detach(IObserver observer);

        /// <summary>
        /// Notify all observers about an event
        /// </summary>
        void Notify();

        /// <summary>
        /// Store experiment's latest state
        /// </summary>
        ExperimentState State { get; set; }
    }
}