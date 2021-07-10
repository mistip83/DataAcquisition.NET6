namespace DataAcquisition.Interface.DeviceManager
{
    public interface IDeviceManager
    {
        /// <summary>
        /// Gets byte array from a particular channel
        /// </summary>
        /// <param name="channelAddress"></param>
        /// <returns></returns>
        byte[] ReadData(int channelAddress);
    }
}