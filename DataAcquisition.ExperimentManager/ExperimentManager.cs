using DataAcquisition.Core.Interfaces.ExperimentManager;
using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.DTOs;

namespace DataAcquisition.ExperimentManager
{
    public class ExperimentManager : IExperimentManager
    {
        private readonly IDeviceLibraryManager _deviceLibraryManager;
        private readonly IConnectionManager _connectionManager;

        public ExperimentManager(IConnectionManager connectionManager, 
            IDeviceLibraryManager deviceLibraryManager)
        {
            _connectionManager = connectionManager;
            _deviceLibraryManager = deviceLibraryManager;
        }

        public async Task GetExperimentData(AcquisitionConfig measurementInfo)
        {
            await DoMeasurement(measurementInfo);
        }

        private async Task DoMeasurement(AcquisitionConfig measurementInfo)
        {
            throw new NotImplementedException();
        }


    }
}
