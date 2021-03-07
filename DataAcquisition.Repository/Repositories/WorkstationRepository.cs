using System;
using System.Threading.Tasks;

namespace DataAcquisition.Repository.Repositories
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