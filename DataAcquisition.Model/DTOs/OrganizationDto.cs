using System.Collections.Generic;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Model.DTOs
{
    public class OrganizationDto
    {
        public CompanyDto Company { get; set; }
        public IEnumerable<FacilityDto> Facilities { get; set; }
        public IEnumerable<WorkstationDto> Workstations { get; set; }
        public IEnumerable<ExperimentDto> Experiments { get; set; }
        public IEnumerable<DeviceDto> Devices { get; set; }
    }
}