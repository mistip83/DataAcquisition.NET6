using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories
{
    public interface IExperimentRepository : IRepository<Experiment>
    {
        /// <summary>
        /// Returns experiment data
        /// </summary>
        /// <param name="id"></param>
        public Task<ExperimentData> GetExperimentDataAsync(int id);
    }
}