using System.Collections.Generic;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Model.DTOs
{
    public class CompanyStructureDto
    {
        public Company Company { get; set; }
        public IEnumerable<Facility> Facilities { get; set; }
        public IEnumerable<Workstation> Workstations { get; set; }
        public IEnumerable<Experiment> Experiments { get; set; }
        public IEnumerable<Device> Devices { get; set; }
    }
}