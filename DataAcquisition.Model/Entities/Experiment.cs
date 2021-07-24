using System;

namespace DataAcquisition.Model.Entities
{
    public class Experiment
    {
        public int ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public string ExperimentDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public int WorkstationId { get; set; }
        public string Email { get; set; }
        public virtual Workstation WorkStation { get; set; }
        public virtual User User { get; set; }
    }
}
