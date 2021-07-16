using DataAcquisition.Model.Device;

namespace DataAcquisition.Interface.Services
{
    public interface IDeviceService
    {
        ChannelInfo GetDeviceChannelInfo();
        void CalibrateDevice();
    }
}