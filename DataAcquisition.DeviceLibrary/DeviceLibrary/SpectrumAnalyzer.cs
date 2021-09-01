﻿using DataAcquisition.Core.Interfaces.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceLibrary
{
    public class SpectrumAnalyzer : IDevice
    {
        /// <summary>
        /// Contains all channels of the device
        /// </summary>
        public int[] ChannelAddressList()
        {
            return new int[]
            {
                1000,
                5000,
                10000,
                20000,
                30000,
                40000,
                50000,
                60000,
                70000,
                80000,
                90000,
                100000
            };
        }
    }
}