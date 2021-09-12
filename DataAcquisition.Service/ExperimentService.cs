using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class ExperimentService : Service<Experiment>, IExperimentService
    {
        private readonly IExperimentManager _experimentManager;
        public ExperimentService(IUnitOfWork unitOfWork, IRepository<Experiment> repository, 
            IExperimentManager experimentManager) : base(unitOfWork, repository)
        {
            _experimentManager = experimentManager;
        }

        public async Task<ExperimentData> GetExperimentDataAsync(int id)
        {
            return await UnitOfWork.Experiments.GetExperimentDataAsync(id);
        }

        public async Task StartNewExperiment(IEnumerable<ChannelConfiguration> channelConfigList)
        {
            await _experimentManager.StartNewExperiment(channelConfigList);
        }
    }
}