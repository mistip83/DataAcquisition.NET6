using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Service.Services
{
    public class FacilityService : Service<Facility>, IFacilityService
    {
        public FacilityService(IUnitOfWork unitOfWork, IRepository<Facility> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Facility> GetFacilityWithWorkStationsAsync(Guid id)
        {
            return await UnitOfWork.Facilities.GetFacilityWithWorkStationsAsync(id);
        }
    }
}