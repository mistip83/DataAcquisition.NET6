using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.Repositories
{
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
        /// <returns></returns>
        public async Task<Facility> GetFacilityWithWorkStationsAsync(Guid id)
        {
            return await AppDbContext.Facilities.Include(x => x.WorkStations)
                .SingleOrDefaultAsync(x => x.FacilityId == id);
        }
    }
}