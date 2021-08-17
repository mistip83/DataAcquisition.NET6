using DataAcquisition.Interface.DeviceManager;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.DeviceManager
{
    public class DeviceManager : IDeviceManager
    {
        public int[] GetDeviceChannelAddressList(DeviceType deviceType)
        {
            return new int[5];
        }
    }
}