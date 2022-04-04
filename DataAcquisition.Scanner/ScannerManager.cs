using DataAcquisition.Core.Interfaces.ScannerManager;

namespace DataAcquisition.Scanner;

public class ScannerManager : IScannerManager
{
    private const int ReadBufferSize = 8;
    private readonly Random _random = new Random();

    public async Task<string> GetData(List<int> channelAddressList)
    {
        var data = new List<double>();

        foreach (var channel in channelAddressList)
        {
            data.Add(await ReadFromDevice(channel));
        }

        return FormatData(data);
    }

    private async Task<double> ReadFromDevice(int channelAddress)
    {
        var bytes = new byte[ReadBufferSize];

        await Task.Run(() => _random.NextBytes(bytes));

        return ConvertRawData(bytes);
    }

    private static double ConvertRawData(byte[] rawData)
    {
        return BitConverter.ToDouble(rawData, 0);
    }

    private static string FormatData(List<double> data)
    {
        return string.Join(";", data);
    }
}