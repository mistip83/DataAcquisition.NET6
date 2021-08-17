using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface IDeviceService : IService<Device>
    {
        Device CalibrateDevice(Device device);
    }
}