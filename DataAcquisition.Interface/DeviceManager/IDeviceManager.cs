using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.DeviceManager
{
    public interface IDeviceManager
    {
        public int[] GetChannelList(DeviceType deviceType);
    }
}