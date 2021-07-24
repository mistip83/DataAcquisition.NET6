using System.Collections.Generic;

namespace DataAcquisition.Model.DTOs
{
    public class FacilityWithWorkstationsDto : FacilityDto
    {
        public IEnumerable<WorkstationDto> Workstations { get; set; }
    }
}