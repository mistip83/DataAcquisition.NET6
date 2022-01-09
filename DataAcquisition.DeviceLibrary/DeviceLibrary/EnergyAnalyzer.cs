using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceLibrary
{
    /// <summary>
    /// Contains physical device properties and methods
    /// </summary>
    public class EnergyAnalyzer : IDevice
    {
        /// <summary>
        /// Contains all channels of the device
        /// </summary>
        public int[] ChannelAddressList()
        {
            return new int[]
            {
                10000,
                10001,
                10002,
                10003,
                10004,
                10005,
                10006
            };
        }
    }
}