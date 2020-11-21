using System.Threading.Tasks;
using Istip.DataAcquisition.Core.EntityModels;

namespace Istip.DataAcquisition.Core.Repositories
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        Task<Facility> GetFacilityWithWorkStationsByFacilityIdAsync(int id);
    }
}
