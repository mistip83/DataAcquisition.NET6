using System;
using System.Threading.Tasks;

namespace DataAcquisition.Repository.Repositories
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