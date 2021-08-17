using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.DeviceManager
{
    public interface IDeviceManager
    {
        /// <summary>
        /// Returns device channel addresses
        /// </summary>
        /// <param name="deviceType"></param>
        int[] GetDeviceChannelAddressList(DeviceType deviceType);
    }
}