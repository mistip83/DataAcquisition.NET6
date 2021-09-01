using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.DeviceManager
{
    public interface IDeviceManager
    {
        public Device CalibrateDevice(Device device);
        public int[] GetChannelList(DeviceType deviceType);
    }
}