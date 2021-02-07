using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        Task<Facility> GetFacilityWithWorkStationsByFacilityIdAsync(Guid id);
    }
}
