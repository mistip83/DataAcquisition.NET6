using DataAcquisition.Core.Interfaces.ExperimentManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.ScannerManager;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.ExperimentManager.Subscribers;

namespace DataAcquisition.ExperimentManager
{
    public class ExperimentManager : IExperimentManager
    {
        private readonly IAcquisitionRepository _acquisitionRepository;
        private readonly IDeviceLibraryManager _deviceLibraryManager;
        private readonly IConnectionManager _connectionManager;
        private readonly IPublisher _publisher;
        private readonly IScannerManager _scannerManager;
        private ExperimentData _experimentData;
        private FrontEndSubscriber _frontEndSubscriber;
        private MailSubscriber _mailSubscriber;
        private SmsSubscriber _smsSubscriber;

        public ExperimentManager(IAcquisitionRepository acquisitionRepository, IConnectionManager connectionManager,
            IPublisher publisher, IDeviceLibraryManager deviceLibraryManager, IScannerManager scannerManager)
        {
            _acquisitionRepository = acquisitionRepository ?? throw new ArgumentNullException(nameof(acquisitionRepository));
            _connectionManager = connectionManager ?? throw new ArgumentNullException(nameof(connectionManager));
            _deviceLibraryManager = deviceLibraryManager ?? throw new ArgumentNullException(nameof(deviceLibraryManager));
            _scannerManager = scannerManager ?? throw new ArgumentNullException(nameof(scannerManager));
            _publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        }

        public async Task ExperimentOrchestrator(AcquisitionConfig config)
        {
            // Create subscribers
            InitializeSubscribers();

            // Initialize Devices
            InitializeDevices(config);

            // Create experiment data object
            CreateExperimentDataInstance(config);

            // Start gathering data
            await StartAcquisitionAsync(config);
        }

        private void CreateExperimentDataInstance(AcquisitionConfig config)
        {
            _experimentData = new ExperimentData() { ExperimentId = config.ExperimentId };
        }

        private async Task StartAcquisitionAsync(AcquisitionConfig config)
        {
            // Notify subscribers
            _publisher.Notify(ExperimentState.CollectingData);

            // Get specific channel addresses to read data 
            var channelIdList = await GetChannelAddressListAsync(config.DeviceType,
                config.ChannelSetup.ChannelIdList).ToListAsync();

            // Set remaining time to Stop Time
            var remainingTime = config.StopTime;
            // Set elapsed time to zero
            var elapsedTime = TimeSpan.Zero;
            // Start acquisition
            while (remainingTime > TimeSpan.Zero)
            {
                // Read device data
                _experimentData.Data = await GetDeviceData(channelIdList);
                // Update elapsed time
                elapsedTime += config.TimeInterval;
                // Update experiment data object
                _experimentData.TimeInterval = elapsedTime;
                // Write it to database
                await SaveDeviceData(_experimentData);
                // Update remaining time
                remainingTime -= config.TimeInterval;
            }
        }

        private async Task SaveDeviceData(ExperimentData experimentData)
        {
            await _acquisitionRepository.AddAsync(experimentData);
        }

        private async Task<string> GetDeviceData(List<int> channelAddressList)
        {
            return await _scannerManager.GetData(channelAddressList);
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

            // Establish connection with the device
            _connectionManager.Connect(config.ConnectionType);
        }

        private async IAsyncEnumerable<int> GetChannelAddressListAsync(DeviceType deviceType,
            IAsyncEnumerable<int> channelIds)
        {
            var channelList = _deviceLibraryManager.GetChannelList(deviceType);

            await foreach (var index in channelIds)
            {
                yield return channelList.ElementAt(index);
            }
        }
    }
}
