using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.Interfaces.UnitOfWorks;
using DataAcquisition.Interface.Models.Entities;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;

namespace DataAcquisition.Service.Services
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
        /// <returns></returns>
        public async Task<Workstation> GetWorkstationWithExperimentsAsync(Guid id)
        {
            return await UnitOfWork.Workstations.GetWorkstationWithExperimentsAsync(id);
        }
    }
}