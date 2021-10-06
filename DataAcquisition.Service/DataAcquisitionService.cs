using DataAcquisition.Core.Interfaces.DataAcquisition;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.Service
{
    public class DataAcquisitionService : IDataAcquisitionService
    {
        private readonly IExperimentManager _experimentManager;
        public DataAcquisitionService(IExperimentManager experimentManager)
        {
            _experimentManager = experimentManager;
        }

        public void StartDataAcquisition(AcquisitionConfig config)
        {
            _experimentManager.ExperimentOrchestrator(config);
        }
    }
}