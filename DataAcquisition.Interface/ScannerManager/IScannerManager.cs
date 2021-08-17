namespace DataAcquisition.Interface.ScannerManager
{
    public interface IScannerManager
    {
        /// <summary>
        /// Returns scanner object
        /// </summary>
        /// <param name="channelAddressList"></param>
        public double[] ReadData(int[] channelAddressList);
    }
}