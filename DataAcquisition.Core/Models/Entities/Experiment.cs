using System;
using System.ComponentModel.DataAnnotations;

namespace DataAcquisition.Core.Models.Entities
{
    public class Experiment
    {
        [Key]
        public Guid ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public virtual Workstation WorkStation { get; set; }
    }
}
