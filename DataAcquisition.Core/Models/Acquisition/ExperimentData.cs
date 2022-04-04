using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Models.Acquisition;

public class ExperimentData
{
    public TimeSpan TimeInterval { get; set; }
    public string Data { get; set; }
    public int ExperimentId { get; set; }
    public virtual Experiment Experiment { get; set; }
}