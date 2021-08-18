using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.DeviceManager
{
    public interface IDeviceManager
    {
        /// <summary>
        /// Creates device instance to reach device's psychical properties
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        public IDevice ExecuteCreation(DeviceType deviceType);
    }
}