using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    /// <summary>
    /// Observer interface to get info from subject
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Receive update from subject
        /// </summary>
        /// <param name="state"></param>
        void Update(ExperimentState state);
    }
}