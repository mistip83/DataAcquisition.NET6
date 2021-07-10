using DataAcquisition.Interface.DeviceManager;
using System;

namespace DataAcquisition.DeviceManager
{
    public class DeviceManager : IDeviceManager
    {
        private const int ReadBufferSize = 8;
        private readonly Random _random = new();

        public byte[] ReadData(int channelAddress)
        {
            var bytes = new byte[ReadBufferSize];
            _random.NextBytes(bytes);

            return bytes;
        }
    }
}