using System.Collections.Generic;

namespace DataAcquisition.Model.DTOs
{
    public class FacilityWithWorkstationsDto
    {
        public string FacilityName { get; set; }
        public IEnumerable<WorkstationNameDto> Workstations { get; set; }
    }
}