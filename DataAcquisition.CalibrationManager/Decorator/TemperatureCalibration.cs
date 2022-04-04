using DataAcquisition.Core.Interfaces.CalibrationManager;

namespace DataAcquisition.CalibrationManager.Decorator;

public class TemperatureCalibration : CalibrationDecorator
{
    public TemperatureCalibration(ICalibration calibration) : base(calibration)
    {
    }

    public override async Task<string> GetCalibrationData(List<int> channelAddressList)
    {
        SetTimer();
        return await base.GetCalibrationData(channelAddressList);
    }

    private static void SetTimer()
    {
        // Create a timer
    }
}