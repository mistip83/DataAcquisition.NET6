using System;
using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class Experiment
    {
        public Guid ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public string ExperimentDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid WorkstationId { get; set; }
        public virtual Workstation WorkStation { get; set; }
        public virtual User User { get; set; }
    }
}
