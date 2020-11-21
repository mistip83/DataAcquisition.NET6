using System;
using System.Collections.Generic;
using Istip.DataAcquisition.Core.Models.Scanner;

namespace Istip.DataAcquisition.Core.Models.Services
{
    public class DeviceChannels
    {
        public Guid DeviceId { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceName { get; set; }
        public IEnumerable<Channel> DefaultChannels { get; set; }
        public IEnumerable<Channel> CurrentChannels { get; set; }
        public IEnumerable<Data> DeviceData { get; set; }
    }
}