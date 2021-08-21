using System;
using System.Collections.Generic;
using DataAcquisition.DeviceManager.DeviceFactory;
using DataAcquisition.Interface.DeviceManager;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.DeviceManager
{
    public class DeviceManager : IDeviceManager
    {
        private readonly Dictionary<DeviceType, AbstractDeviceFactory> _factories;

        public DeviceManager()
        {
            _factories = new Dictionary<DeviceType, AbstractDeviceFactory>();

            foreach (DeviceType deviceType in Enum.GetValues(typeof(DeviceType)))
            {
                var factory = (AbstractDeviceFactory) Activator.CreateInstance(
                    Type.GetType(typeof(AbstractDeviceFactory).Namespace + "." +
                                 Enum.GetName(typeof(DeviceType), deviceType) + "Factory") ??
                    throw new InvalidOperationException());

                _factories.Add(deviceType, factory);
            }
        }

        public IDevice ExecuteCreation(DeviceType deviceType) => _factories[deviceType].Create();
    }
}