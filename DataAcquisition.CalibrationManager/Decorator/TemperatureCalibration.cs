using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using DataAcquisition.Core.Interfaces.CalibrationManager;

namespace DataAcquisition.CalibrationManager.Decorator;

public class TemperatureCalibration : CalibrationDecorator
{
    private static Timer _timer;
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
        // Create a timer with a two second interval.
        _timer = new Timer(2000)
        { 
            // _timer.Elapsed += OnTimedEvent;
            AutoReset = true,
            Enabled = true
        };
    }

    private static void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
            e.SignalTime);
    }
}