using DataAcquisition.Core.Interfaces.ExperimentManager;
using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Enums;
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
        private readonly ISubject _subject;

        public ExperimentManager(IConnectionManager connectionManager, 
            IDeviceLibraryManager deviceLibraryManager, ISubject subject)
        {
            _connectionManager = connectionManager;
            _deviceLibraryManager = deviceLibraryManager;
            _subject = subject;
        }

        public ExperimentState GetExperimentSate()
        {
            return _subject.State;
        }

        public void SetExperimentState(ExperimentState state)
        {
            _subject.State = state;
            _subject.Notify();
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
