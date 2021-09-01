using System.Collections.Generic;

namespace DataAcquisition.Core.Models.DTOs
{
    public class WorkstationWithDevicesAndExps : WorkstationDto
    {
        public IEnumerable<DeviceNameDto> Devices { get; set; }
        public IEnumerable<ExperimentNameDto> Experiments { get; set; }
    }
}