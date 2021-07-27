using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Repositories
{
    public interface IExperimentRepository : IRepository<Experiment>
    {
        /// <summary>
        /// Returns experiment data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<ExperimentData> GetExperimentDataAsync(int id);
    }
}