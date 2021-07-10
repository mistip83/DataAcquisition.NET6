namespace DataAcquisition.Interface.ConnectionManager
{
    public interface IConnectionManager
    {
        public void ConnectToDevice();

        public void ConnectToSimulator();
    }
}