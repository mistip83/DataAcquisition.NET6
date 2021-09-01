using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.DeviceManager
{
    public interface IDeviceManager
    {
        public int[] GetChannelList(DeviceType deviceType);
    }
}