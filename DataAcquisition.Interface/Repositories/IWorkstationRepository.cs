using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Repositories
{
    public interface IWorkstationRepository : IRepository<Workstation>
    {
        /// <summary>
        /// Returns workstation entity with its experiments
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Workstation> GetWorkstationWithExperimentsAsync(int id);
    }
}
