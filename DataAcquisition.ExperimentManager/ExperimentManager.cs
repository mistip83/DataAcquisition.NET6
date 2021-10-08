using DataAcquisition.Core.Interfaces.ExperimentManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.ScannerManager;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.ExperimentManager.Subscribers;

namespace DataAcquisition.ExperimentManager
{
    public class ExperimentManager : IExperimentManager
    {
        private readonly IDeviceLibraryManager _deviceLibraryManager;
        private readonly IConnectionManager _connectionManager;
        private readonly IPublisher _publisher;
        private readonly IScannerManager _scannerManager;
        private FrontEndSubscriber _frontEndSubscriber;
        private MailSubscriber _mailSubscriber;
        private SmsSubscriber _smsSubscriber;

        public ExperimentManager(IConnectionManager connectionManager, IPublisher publisher,
            IDeviceLibraryManager deviceLibraryManager, IScannerManager scannerManager)
        {
            _connectionManager = connectionManager ?? throw new ArgumentNullException(nameof(connectionManager));
            _deviceLibraryManager = deviceLibraryManager ?? throw new ArgumentNullException(nameof(deviceLibraryManager));
            _scannerManager = scannerManager ?? throw new ArgumentNullException(nameof(scannerManager));
            _publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        }

        public void ExperimentOrchestrator(AcquisitionConfig config)
        {
            // Create subscribers
            InitializeSubscribers();

            // Initialize Devices
            InitializeDevices(config);

            // Start gathering data
            StartAcquisition(config);
        }

        private void StartAcquisition(AcquisitionConfig config)
        {
            // Notify subscribers
            _publisher.Notify(ExperimentState.CollectingData);

            // Get specific channel addresses to read data 
            var channelIdList = GetChannelAddresses(config.DeviceType,
                config.ChannelSetup.ChannelIdList);

            // Get data from device
            var remainingTime = config.StopTime;
            var elapsedTime = TimeSpan.Zero;
            while (remainingTime > TimeSpan.Zero)
            {
                var data = string.Join(";", GetDeviceData(channelIdList));
                elapsedTime += config.TimeInterval;
                remainingTime -= config.TimeInterval;
            }
        }

        public string GetDeviceData(int[] channelAddressList) =>
            _scannerManager.GetData(channelAddressList);

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

            // Establish connection with the device
            _connectionManager.Connect(config.ConnectionType);
        }

        private int[] GetChannelAddresses(DeviceType deviceType, int[] channelIds)
        {
            return _deviceLibraryManager.GetChannelList(deviceType)
                .Join(channelIds,
                    int1 => int1,
                    int2 => int2,
                    (int1, int2) => int1).ToArray();
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
