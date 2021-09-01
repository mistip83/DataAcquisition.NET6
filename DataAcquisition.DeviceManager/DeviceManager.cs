using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.DeviceManager;

namespace DataAcquisition.DeviceManager
{
    public class DeviceManager : IDeviceManager
    {
        private readonly IDeviceLibraryManager _deviceLibraryManager;

        public DeviceManager(IDeviceLibraryManager deviceLibraryManager)
        {
            _deviceLibraryManager = deviceLibraryManager;
        }

        public int[] GetChannelList(DeviceType deviceType)
        {
           return _deviceLibraryManager.ExecuteCreation(deviceType).ChannelAddressList();
        }
    }
}