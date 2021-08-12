using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceLibrary
{
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