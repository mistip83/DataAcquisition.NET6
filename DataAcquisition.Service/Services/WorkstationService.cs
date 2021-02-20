using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

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

        public async Task<Workstation> GetWorkstationWithExperimentsAsync(Guid id)
        {
            return await UnitOfWork.Workstations.GetWorkstationWithExperimentsAsync(id);
        }
    }
}