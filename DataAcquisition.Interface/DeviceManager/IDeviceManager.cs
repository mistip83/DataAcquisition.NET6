using System.Collections.Generic;

namespace DataAcquisition.Interface.DeviceManager
{
    public interface IDeviceManager
    {

        /// <summary>
        /// Gets byte array from a particular channel
        /// </summary>
        /// <param name="channelAddressList"></param>
        /// <returns></returns>
        double[] ReadData(int[] channelAddressList);
    }
}