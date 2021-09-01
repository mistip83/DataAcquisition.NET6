using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IExperimentService : IService<Experiment>
    {
        /// <summary>
        /// Returns experiment data
        /// </summary>
        /// <param name="id"></param>
        public Task<ExperimentData> GetExperimentDataAsync(int id);
    }
}