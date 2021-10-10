using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.DataAccessEF.DataAccess;

namespace DataAcquisition.Repository.Repositories
{
    public class ExperimentRepository : Repository<Experiment>, IExperimentRepository
    {
        private AppDbContext AppDbContext => Context;

        public ExperimentRepository(AppDbContext context) : base(context)
        {
        }
    }
}