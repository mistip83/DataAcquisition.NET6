using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface IFacilityService : IService<Facility>
    {
        /// <summary>
        /// Returns facility entity with its workstations
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Facility> GetFacilityWithWorkStationsAsync(int id);
    }
}