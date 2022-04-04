namespace DataAcquisition.Core.Interfaces.ScannerManager;

public interface IScannerManager
{
    /// <summary>
    /// Returns data from the device
    /// </summary>
    /// <param name="channelAddressList"></param>
    Task<string> GetData(List<int> channelAddressList);
}