using System;
using DataAcquisition.Core.Interfaces.ScannerManager;

namespace DataAcquisition.Scanner
{
    public class ScannerManager : IScannerManager
    {
        private const int ReadBufferSize = 8;
        private readonly Random _random = new Random();

        public string GetData(int[] channelAddressList)
        {
            var data = new double[channelAddressList.Length];
            for (var i = 0; i < channelAddressList.Length; i++)
            {
                data[i] = ReadFromDevice(channelAddressList[i]);
            }

            return FormatData(data);
        }

        private double ReadFromDevice(int channelAddress)
        {
            var bytes = new byte[ReadBufferSize];
            _random.NextBytes(bytes);

            return ConvertRawData(bytes);
        }

        private static double ConvertRawData(byte[] rawData)
        {
            return BitConverter.ToDouble(rawData, 0);
        }

        private static string FormatData(double[] data)
        {
            return string.Join(";", data);
        }
    }
}
