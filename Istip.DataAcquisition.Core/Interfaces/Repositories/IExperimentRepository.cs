using System.Threading.Tasks;
using Istip.DataAcquisition.Core.Models.Entities;

namespace Istip.DataAcquisition.Core.Interfaces.Repositories
{
    public interface IExperimentRepository : IRepository<Experiment>
    {
        Task<Experiment> GetExperimentWithDevicesByExperimentIdAsync(int id);
    }
}
