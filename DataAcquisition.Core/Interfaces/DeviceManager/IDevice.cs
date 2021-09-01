namespace DataAcquisition.Core.Interfaces.DeviceManager
{
    public interface IDevice
    {
        /// <summary>
        /// Contains all channels of the device
        /// </summary>
        public int[] ChannelAddressList();
    }
}