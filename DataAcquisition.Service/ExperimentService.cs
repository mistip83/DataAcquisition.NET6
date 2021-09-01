using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service
{
    public class ExperimentService : Service<Experiment>, IExperimentService
    {
        public ExperimentService(IUnitOfWork unitOfWork, IRepository<Experiment> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<ExperimentData> GetExperimentDataAsync(int id)
        {
            return await UnitOfWork.Experiments.GetExperimentDataAsync(id);
        }
    }
}