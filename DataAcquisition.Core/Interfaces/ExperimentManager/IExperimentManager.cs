using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcquisition.Core.Models;

namespace DataAcquisition.Core.Interfaces.ExperimentManager
{
    public interface IExperimentManager
    {
        public Task StartNewExperiment(IEnumerable<ChannelConfiguration> channelConfigList);
    }
}