using System.Threading.Tasks;

namespace DataAcquisition.Interface.CalibrationManager
{
    public interface ICalibrationManager
    {
        double GetCalibrationData(int channelAddress);
    }
}
