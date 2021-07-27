using DataAcquisition.Interface.Services;
using DataAcquisition.Model.Entities;
using System.Threading.Tasks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.UnitOfWorks;

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