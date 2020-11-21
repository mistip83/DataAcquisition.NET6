using System.Threading.Tasks;
using Istip.DataAcquisition.Core.Models.Entities;

namespace Istip.DataAcquisition.Core.Interfaces.Repositories
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        Task<Facility> GetFacilityWithWorkStationsByFacilityIdAsync(int id);
    }
}
