namespace DataAcquisition.Core.Interfaces.ScannerManager
{
    public interface IScannerManager
    {
        /// <summary>
        /// Returns data from the device
        /// </summary>
        /// <param name="channelAddressList"></param>
        string GetData(int[] channelAddressList);
    }
}