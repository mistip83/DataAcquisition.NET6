using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Istip.DataAcquisition.Core.EntityModels;

namespace Istip.DataAcquisition.Core.Repositories
{
    interface IExperimentRepository : IRepository<Experiment>
    {
        Task<Experiment> GetExperimentWithDevicesByExperimentIdAsync(int id);
    }
}
