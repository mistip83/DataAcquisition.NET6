using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class Workstation
    {
        public int WorkstationId { get; set; }
        public string WorkstationName { get; set; }
        public string WorkstationDescription { get; set; }
        public bool IsDeleted { get; set; }
        public int FacilityId { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual ICollection<Experiment> Experiments { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
