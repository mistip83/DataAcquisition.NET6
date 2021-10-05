using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ExperimentManager;

namespace DataAcquisition.ExperimentManager.Observer
{
    public class SmsObserver : IObserver
    {
        public SmsObserver(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Update(ExperimentState state)
        {
            // TODO: send state to mobile phone
        }
    }
}