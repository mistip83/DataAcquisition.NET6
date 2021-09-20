using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class WorkstationService : Service<Workstation>, IWorkstationService
    {
        public WorkstationService(IUnitOfWork unitOfWork, IRepository<Workstation> repository) : base(unitOfWork, repository)
        {
        }

        /// <summary>
        /// Returns workstation entity with its experiments
        /// </summary>
        /// <param name="id"></param>
        public async Task<Workstation> GetWorkstationWithDevicesAndExperimentsAsync(int id)
        {
            return await UnitOfWork.Workstation.GetWorkstationWithDevicesAndExperimentsAsync(id);
        }
    }
}