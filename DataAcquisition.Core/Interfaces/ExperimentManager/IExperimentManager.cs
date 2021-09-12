using System.Threading.Tasks;
using DataAcquisition.Core.Models.DTOs;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IExperimentManager
    {
        public Task GetExperimentData(MeasurementDto measurementInfo);
    }
}