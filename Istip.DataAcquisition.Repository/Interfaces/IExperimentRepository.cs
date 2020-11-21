using Istip.DataAcquisition.Core.EntityModels;
using System.Threading.Tasks;

namespace Istip.DataAcquisition.Repository.Interfaces
{
    interface IExperimentRepository : IRepository<Experiment>
    {
        Task<Experiment> GetExperimentWithDevicesByExperimentIdAsync(int id);
    }
}
