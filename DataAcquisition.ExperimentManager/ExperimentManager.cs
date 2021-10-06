using DataAcquisition.Core.Interfaces.ExperimentManager;
using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.DTOs;
using DataAcquisition.ExperimentManager.Subscribers;

namespace DataAcquisition.ExperimentManager
{
    public class ExperimentManager : IExperimentManager
    {
        private readonly IDeviceLibraryManager _deviceLibraryManager;
        private readonly IConnectionManager _connectionManager;
        private readonly IPublisher _publisher;
        private FrontEndSubscriber _frontEndSubscriber;
        private MailSubscriber _mailSubscriber;
        private SmsSubscriber _smsSubscriber;

        public ExperimentManager(IConnectionManager connectionManager, IPublisher publisher,
            IDeviceLibraryManager deviceLibraryManager)
        {
            _connectionManager = connectionManager ?? throw new ArgumentNullException(nameof(connectionManager));
            _deviceLibraryManager = deviceLibraryManager ?? throw new ArgumentNullException(nameof(deviceLibraryManager));
            _publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        }

        public void ExperimentOrchestrator(AcquisitionConfig config)
        {
            // Create subscribers
            InitializeSubscribers();

            // Initialize Devices
            InitializeDevices(config);


        }

        private void InitializeSubscribers()
        {
            _frontEndSubscriber = new FrontEndSubscriber(_publisher);
            _mailSubscriber = new MailSubscriber(_publisher);
            _smsSubscriber = new SmsSubscriber(_publisher);

            _frontEndSubscriber.Subscribe();
            _mailSubscriber.Subscribe();
            _smsSubscriber.Subscribe();
        }

        private void InitializeDevices(AcquisitionConfig config)
        {
            // Notify subscribers
            _publisher.Notify(ExperimentState.SetupDevices);

            // Establish connection with the devices
            _connectionManager.Connect(config.ConnectionTypeList);
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
