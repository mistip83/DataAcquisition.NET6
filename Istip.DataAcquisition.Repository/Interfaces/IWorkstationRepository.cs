using System.Threading.Tasks;
using Istip.DataAcquisition.Core.EntityModels;

namespace Istip.DataAcquisition.Repository.Interfaces
{
    public interface IWorkstationRepository : IRepository<Workstation>
    {
        Task<Workstation> GetWorkstationWithExperimentsByWorkstationIdAsync(int id);
    }
}
