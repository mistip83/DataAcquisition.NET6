using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services;

public interface IFacilityService : IService<Facility>
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