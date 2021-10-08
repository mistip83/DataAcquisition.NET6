using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service
{
    public class AcquisitionService : Service<ExperimentData>, IAcquisitionService
    {
        private readonly IExperimentManager _experimentManager;

        public AcquisitionService(IUnitOfWork unitOfWork, IRepository<ExperimentData> repository, 
            IExperimentManager experimentManager) : base(unitOfWork, repository)
        {
            _experimentManager = experimentManager;
        }

        public void StartDataAcquisition(AcquisitionConfig config)
        {
            _experimentManager.ExperimentOrchestrator(config);
        }
    }
}