using DataAcquisition.Interface.DeviceManager;
using System;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.DeviceManager
{
    public class DeviceManager : IDeviceManager
    {
        private const int ReadBufferSize = 8;
        private readonly Random _random = new();
        
        //public IDevice CreateDevice(DeviceType deviceType)
        //{
        //    var instance = Activator.CreateInstance<deviceType>();
        //}

        public double[] ReadData(int[] channelAddressList)
        {
            var data = new double[channelAddressList.Length - 1];
            for (var i = 0; i < channelAddressList.Length; i++)
            {
                data[i] = ReadData(channelAddressList[i]);
            }

            return data;
        }

        private double ReadData(int channelAddress)
        {
            var bytes = new byte[ReadBufferSize];
            _random.NextBytes(bytes);

            return ConvertRawData(bytes);
        }

        private static double ConvertRawData(byte[] rawData)
        {
            return BitConverter.ToDouble(rawData, 0);
        }
    }
}