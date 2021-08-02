namespace DataAcquisition.DeviceLibrary
{
    public class DigitalMultimeter
    {
        /// <summary>
        /// Contains all channels of the device
        /// </summary>
        public int[] ChannelAddressList()
        {
            return new int[]
            {
                40000,
                40001,
                40002,
                40003,
                40004,
                40005,
                40006,
                40007,
                40008,
                40009,
                40010,
                40011,
                40012,
                40013,
                40014
            };
        }
    }
}