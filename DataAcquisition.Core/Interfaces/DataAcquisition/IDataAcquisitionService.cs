using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.Core.Interfaces.DataAcquisition
{
    public interface IDataAcquisitionService
    {
        void StartDataAcquisition(AcquisitionConfig config);
    }
}