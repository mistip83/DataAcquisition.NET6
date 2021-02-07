using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.Repositories
{
    public class FacilityReposity : Repository<Facility>, IFacilityRepository
    {
        private AppDbContext AppDbContext => Context as AppDbContext;

        public FacilityReposity(DbContext context) : base(context)
        {
        }

        public async Task<Facility> GetFacilityWithWorkStationsByFacilityIdAsync(Guid id)
        {
            return await AppDbContext.Facilities.Include(x => x.WorkStations)
                .SingleOrDefaultAsync(x => x.FacilityId == id);
        }
    }
}