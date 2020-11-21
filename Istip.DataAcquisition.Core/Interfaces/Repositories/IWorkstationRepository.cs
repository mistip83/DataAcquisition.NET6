using System.Threading.Tasks;
using Istip.DataAcquisition.Core.Models.Entities;

namespace Istip.DataAcquisition.Core.Interfaces.Repositories
{
    public interface IWorkstationRepository : IRepository<Workstation>
    {
        Task<Workstation> GetWorkstationWithExperimentsByWorkstationIdAsync(int id);
    }
}
