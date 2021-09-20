namespace DataAcquisition.Core.Interfaces.DeviceLibrary
{
    public interface IDevice
    {
        /// <summary>
        /// Contains all channels of the device
        /// </summary>
        public int[] ChannelAddressList();
    }
}