using System.Threading.Tasks;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Repository.Repositories
{
    public class ExperimentRepository : Repository<Experiment>, IExperimentRepository
    {
        private AppDbContext AppDbContext => Context;

        public ExperimentRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Implementation detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ExperimentData> GetExperimentDataAsync(int id)
        {
            return await AppDbContext.ExperimentData.SingleOrDefaultAsync(e => e.ExperimentId == id);
        }
    }
}