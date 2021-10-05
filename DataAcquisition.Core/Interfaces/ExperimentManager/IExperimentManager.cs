using System.Threading.Tasks;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.DTOs;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IExperimentManager
    {
        public void ExperimentOrchestrator(AcquisitionConfig config, ExperimentDto experimentDto);
        public Task GetExperimentData(AcquisitionConfig config);
    }
}