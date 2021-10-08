using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IAcquisitionService : IService<ExperimentData>
    {
        void StartDataAcquisition(AcquisitionConfig config);
    }
}