using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.DeviceManager;

namespace DataAcquisition.Core.Interfaces.DeviceLibrary
{
    public interface IDeviceLibraryManager
    {
        /// <summary>
        /// Creates device instance to reach device's psychical properties
        /// </summary>
        /// <param name="deviceType"></param>
        public IDevice ExecuteCreation(DeviceType deviceType);
    }
}