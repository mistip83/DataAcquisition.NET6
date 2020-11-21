using System.Threading.Tasks;
using Istip.DataAcquisition.Core.EntityModels;

namespace Istip.DataAcquisition.Repository.Interfaces
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        Task<Facility> GetFacilityWithWorkStationsByFacilityIdAsync(int id);
    }
}
