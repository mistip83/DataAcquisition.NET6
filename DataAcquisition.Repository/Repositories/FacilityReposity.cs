using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.DataAccessEF.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Repository.Repositories;

/// <summary>
/// Encapsulate the logic required to access data sources
/// </summary>
public class FacilityReposity : Repository<Facility>, IFacilityRepository
{
    private AppDbContext AppDbContext => Context;

    public FacilityReposity(AppDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Implementation detail
    /// </summary>
    /// <param name="id"></param>
    public async Task<Facility> GetFacilityWithWorkStationsAsync(int id)
    {
        return await AppDbContext.Facility.Include(x => x.WorkStations)
            .SingleOrDefaultAsync(x => x.FacilityId == id);
    }

    /// <summary>
    /// Implementation detail
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<Facility>> GetFacilitiesWithWorkStationsAsync()
    {
        return await AppDbContext.Facility.Include(x => x.WorkStations).ToListAsync();
    }
}