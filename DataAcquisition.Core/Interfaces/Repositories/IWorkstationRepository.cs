using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories
{
    public interface IWorkstationRepository : IRepository<Workstation>
    {
        Task<Workstation> GetWorkstationWithExperimentsByWorkstationIdAsync(int id);
    }
}
