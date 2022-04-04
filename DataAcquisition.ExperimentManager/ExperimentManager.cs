using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.ScannerManager;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.ExperimentManager.Subscribers;


namespace DataAcquisition.ExperimentManager;

public class ExperimentManager : IExperimentManager
{
    private readonly IDeviceLibraryManager _deviceLibraryManager;
    private readonly IConnectionManager _connectionManager;
    private readonly IPublisher _publisher;
    private readonly IScannerManager _scannerManager;
    private ExperimentData _experimentData;
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

    public async Task ExperimentOrchestrator(AcquisitionConfig config)
    {
        // Create subscribers
        InitializeSubscribers();

        // Initialize Devices
        InitializeDevices(config);

        // Create experiment data object
        CreateExperimentDataInstance(config);

        // Start collecting data
        await StartAcquisitionAsync(config);

        ReleaseDevices(config);

        CompleteExperiment(config);
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

    private void CreateExperimentDataInstance(AcquisitionConfig config)
    {
        _experimentData = new ExperimentData() { ExperimentId = config.ExperimentId };
    }

    private async Task StartAcquisitionAsync(AcquisitionConfig config)
    {
        // Notify subscribers
        _publisher.Notify(ExperimentState.CollectingData);

        // Get specific channel addresses to read data 
        var channelIdList = GetChannelAddressList(config.DeviceType,
            config.ChannelIdList);

        // Read data and save it
        await DoMeasurement(config, channelIdList);
    }

    private IEnumerable<int> GetChannelAddressList(DeviceType deviceType, List<int> channelIds)
    {
        var channelList = _deviceLibraryManager.GetChannelList(deviceType);

        return channelIds.Select(index => channelList.ElementAt(index));
    }

    private async Task DoMeasurement(AcquisitionConfig config, IEnumerable<int> channelIdList)
    {
        // Set remaining time to Stop Time
        var remainingTime = config.StopTime;
        // Set elapsed time to zero
        var elapsedTime = TimeSpan.Zero;
        // Start acquisition
        while (remainingTime > TimeSpan.Zero)
        {
            // Read device data
            _experimentData.Data = await GetDeviceData(channelIdList.ToList());
            // Update elapsed time
            elapsedTime += config.TimeInterval;
            // Update experiment data object
            _experimentData.TimeInterval = elapsedTime;
            // Write it to database
            SaveDeviceData(_experimentData);
            // Update remaining time
            remainingTime -= config.TimeInterval;
        }
    }

    private async Task<string> GetDeviceData(List<int> channelAddressList)
    {
        return await _scannerManager.GetData(channelAddressList);
    }

    private void SaveDeviceData(ExperimentData experimentData)
    {
        // TODO: Commit to NoSQL
        return;
    }

    private void ReleaseDevices(AcquisitionConfig config)
    {
        // Notify subscribers
        _publisher.Notify(ExperimentState.ReleaseDevices);
    }

    private void CompleteExperiment(AcquisitionConfig config)
    {
        // Notify subscribers
        _publisher.Notify(ExperimentState.Completed);
    }
}