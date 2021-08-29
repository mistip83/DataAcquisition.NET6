using System.Threading.Tasks;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;

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
        public async Task<Facility> GetFacilityWithWorkStationsAsync(int id)
        {
            return await AppDbContext.Facility.Include(x => x.WorkStations)
                .SingleOrDefaultAsync(x => x.FacilityId == id);
        }
    }
}