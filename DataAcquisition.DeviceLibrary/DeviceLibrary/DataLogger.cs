﻿using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceLibrary;

/// <summary>
/// Contains physical device properties and methods
/// </summary>
public class DataLogger : IDevice
{
    /// <summary>
    /// Contains all channels of the device
    /// </summary>
    public int[] ChannelAddressList()
    {
        return new int[]
        {
            100,
            101,
            102,
            103,
            104,
            105,
            106,
            107,
            108,
            109,
            200,
            201,
            202,
            203,
            204,
            205,
            206,
            207,
            208,
            209
        };
    }
}