using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ExperimentManager;

namespace DataAcquisition.ExperimentManager.Observer
{
    public class MailObserver : IObserver
    {
        public MailObserver(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Update(ExperimentState state)
        {
            // TODO: send state via mail
        }
    }
}