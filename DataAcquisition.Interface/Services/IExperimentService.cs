using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface IExperimentService : IService<Experiment>
    {
        /// <summary>
        /// Returns experiment data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<ExperimentData> GetExperimentDataAsync(int id);
    }
}