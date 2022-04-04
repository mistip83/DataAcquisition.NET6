using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.DeviceLibrary.DeviceFactory;

namespace DataAcquisition.DeviceLibrary;

public class DeviceLibraryManager : IDeviceLibraryManager
{
    /// <summary>
    /// Collection of device factories
    /// </summary>
    private Dictionary<DeviceType, AbstractFactory> _factories;

    /// <summary>
    /// Returns address list regarding the device type 
    /// </summary>
    /// <param name="deviceType"></param>
    /// <returns></returns>
    public int[] GetChannelList(DeviceType deviceType) =>
        ExecuteCreation(deviceType).ChannelAddressList();

    /// <summary>
    /// Creates corresponding device object
    /// </summary>
    /// <param name="deviceType"></param>
    private IDevice ExecuteCreation(DeviceType deviceType)
    {
        InitializeFactories();
        return _factories[deviceType].Create();
    }

    /// <summary>
    /// Adds device factory instances
    /// </summary>
    private void InitializeFactories()
    {
        _factories = new Dictionary<DeviceType, AbstractFactory>();

        foreach (DeviceType deviceType in Enum.GetValues(typeof(DeviceType)))
        {
            var factory = (AbstractFactory)Activator.CreateInstance(
                Type.GetType(typeof(AbstractFactory).Namespace + "." +
                             Enum.GetName(typeof(DeviceType), deviceType)) ??
                throw new InvalidOperationException());

            _factories.Add(deviceType, factory);
        }
    }
}