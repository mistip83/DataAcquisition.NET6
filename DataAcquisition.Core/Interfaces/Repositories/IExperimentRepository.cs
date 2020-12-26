using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories
{
    public interface IExperimentRepository : IRepository<Experiment>
    {
        Task<Experiment> GetExperimentWithDevicesByExperimentIdAsync(int id);
    }
}
