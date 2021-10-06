using System.Threading.Tasks;
using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IExperimentManager
    {
        public void ExperimentOrchestrator(AcquisitionConfig config);
        public Task GetExperimentData(AcquisitionConfig config);
    }
}