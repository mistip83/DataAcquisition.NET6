using System.Collections.Generic;

namespace DataAcquisition.Model.DTOs
{
    public class WorkstationWithDevicesAndExps : WorkstationDto
    {
        public IEnumerable<DeviceNameDto> Devices { get; set; }
        public IEnumerable<ExperimentNameDto> Experiments { get; set; }
    }
}