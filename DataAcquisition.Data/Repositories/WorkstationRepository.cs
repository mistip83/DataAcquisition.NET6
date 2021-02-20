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
    public class WorkstationRepository : Repository<Workstation>, IWorkstationRepository
    {
        private AppDbContext AppDbContext => Context;

        public WorkstationRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Implementation detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Workstation> GetWorkstationWithExperimentsAsync(Guid id)
        {
            return await AppDbContext.Workstations.Include(x => x.Experiments)
                .SingleOrDefaultAsync(x => x.WorkstationId == id);
        }
    }
}