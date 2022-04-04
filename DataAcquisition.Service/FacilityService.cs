using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service;

public class FacilityService : Service<Facility>, IFacilityService
{
    public FacilityService(IUnitOfWork unitOfWork, IRepository<Facility> repository) 
        : base(unitOfWork, repository)
    {
    }

    public async Task<Facility> GetFacilityWithWorkStationsAsync(int id)
    {
        return await UnitOfWork.Facility.GetFacilityWithWorkStationsAsync(id);
    }

    public async Task<IEnumerable<Facility>> GetFacilitiesWithWorkStationsAsync()
    {
        return await UnitOfWork.Facility.GetFacilitiesWithWorkStationsAsync();
    }
}