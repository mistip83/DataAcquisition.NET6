using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories;

public interface IFacilityRepository : IRepository<Facility>
{
    /// <summary>
    /// Returns facility entity with its workstations
    /// </summary>
    /// <param name="id"></param>
    public Task<Facility> GetFacilityWithWorkStationsAsync(int id);

    /// <summary>
    /// Returns all facilities entity with their workstations
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<Facility>> GetFacilitiesWithWorkStationsAsync();
}