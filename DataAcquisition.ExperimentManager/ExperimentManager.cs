using DataAcquisition.Core.Interfaces.ExperimentManager;
using System;
using System.Collections.Generic;
using DataAcquisition.Core.Models;
using System.Threading.Tasks;

namespace DataAcquisition.ExperimentManager
{
    public class ExperimentManager : IExperimentManager
    {
        public Task StartNewExperiment(IEnumerable<ChannelConfiguration> channelConfigList)
        {
            throw new NotImplementedException();
        }


    }
}
