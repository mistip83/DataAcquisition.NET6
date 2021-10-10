using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.DataAccessEF.DataAccess;

namespace DataAcquisition.Repository.Repositories
{
    public class AcquisitionRepository : Repository<ExperimentData>, IAcquisitionRepository
    {
        private AppDbContext AppDbContext => Context;

        public AcquisitionRepository(AppDbContext context) : base(context)
        {
        }
    }
}