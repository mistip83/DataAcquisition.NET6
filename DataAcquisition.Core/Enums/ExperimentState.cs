namespace DataAcquisition.Core.Enums;

public enum ExperimentState
{
    Created = 1,
    SetupDevices = 2,
    CollectingData = 3,
    Paused = 4,
    Stopped = 5,
    ReleaseDevices = 6,
    Completed = 7
}