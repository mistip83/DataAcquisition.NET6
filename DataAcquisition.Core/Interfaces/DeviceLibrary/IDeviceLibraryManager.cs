using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.DeviceLibrary;

public interface IDeviceLibraryManager
{
    /// <summary>
    /// Returns address list regarding the device type
    /// </summary>
    /// <param name="deviceType"></param>
    int[] GetChannelList(DeviceType deviceType);
}