using System.Collections.Generic;

namespace DataAcquisition.Model.DTOs
{
    public class OrganizationDto : CompanyDto
    {
        public IEnumerable<FacilityWithWorkstationsDto> Facilities { get; set; }
    }
}