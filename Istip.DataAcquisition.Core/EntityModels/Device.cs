using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istip.DataAcquisition.Core.EntityModels
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
