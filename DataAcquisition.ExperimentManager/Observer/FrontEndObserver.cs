using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ExperimentManager;

namespace DataAcquisition.ExperimentManager.Observer
{
    public class FrontEndObserver : IObserver
    {
        public FrontEndObserver(ISubject subject)
        {
            subject.Attach(this);
        }
        public void Update(ExperimentState state)
        {
            // TODO: send state to UI
        }
    }
}