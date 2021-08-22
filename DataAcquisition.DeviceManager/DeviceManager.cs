using DataAcquisition.Interface.DeviceLibrary;
using DataAcquisition.Interface.DeviceManager;
using DataAcquisition.Model.Enums;

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