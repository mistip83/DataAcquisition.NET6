using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.Repositories
{
    public class WorkstationRepository : Repository<Workstation>, IWorkstationRepository
    {
        private AppDbContext AppDbContext => Context as AppDbContext;

        public WorkstationRepository(DbContext context) : base(context)
        {
        }

        public async Task<Workstation> GetWorkstationWithExperimentsByWorkstationIdAsync(Guid id)
        {
            return await AppDbContext.Workstations.Include(x => x.Experiments)
                .SingleOrDefaultAsync(x => x.WorkStationId == id);
        }
    }
}