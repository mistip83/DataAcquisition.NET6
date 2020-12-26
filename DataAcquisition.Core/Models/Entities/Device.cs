using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcquisition.Core.Models.Entities
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceName { get; set; }

        [ForeignKey("ExperimentId")]
        public virtual Experiment Experiment { get; set; }
    }
}
