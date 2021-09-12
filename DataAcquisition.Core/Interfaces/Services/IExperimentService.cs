using System.Threading.Tasks;
using DataAcquisition.Core.Models.DTOs;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IExperimentService : IService<Experiment>
    {
        /// <summary>
        /// Return experiment data
        /// </summary>
        /// <param name="id"></param>
        public Task<ExperimentData> GetExperimentDataAsync(int id);

        /// <summary>
        /// Create a new experiment and start data acquisition
        /// </summary>
        /// <param name="measurementInfo"></param>
        public Task StartNewExperiment(MeasurementDto measurementInfo);
    }
}