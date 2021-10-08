using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.DataAccessEF.DataAccess;
using Microsoft.EntityFrameworkCore;

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