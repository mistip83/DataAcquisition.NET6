using System.Collections.Generic;

namespace DataAcquisition.Core.Models.DTOs
{
    public class OrganizationDto : CompanyDto
    {
        public IEnumerable<FacilityWithWorkstationsDto> Facilities { get; set; }
    }
}