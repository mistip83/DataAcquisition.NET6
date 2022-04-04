using System.Threading.Tasks;
using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.Core.Interfaces.Services;

public interface IAcquisitionService : IService<ExperimentData>
{
    Task StartDataAcquisition(AcquisitionConfig config);
}