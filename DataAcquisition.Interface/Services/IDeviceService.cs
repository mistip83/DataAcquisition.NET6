using DataAcquisition.Model.Device;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface IDeviceService : IService<Device>
    {
        ChannelInfo GetDeviceChannelInfo();
        void CalibrateDevice();
    }
}