using DataAcquisition.Interface.DeviceManager;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.DeviceLibrary
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