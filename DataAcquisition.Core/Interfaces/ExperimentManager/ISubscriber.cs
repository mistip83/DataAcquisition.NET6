using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface ISubscriber
    {
        /// <summary>
        /// Subscribe to a publisher
        /// </summary>
        void Subscribe();

        /// <summary>
        /// Unsubscribe from a publisher
        /// </summary>
        void UnSubscribe();
    }
}