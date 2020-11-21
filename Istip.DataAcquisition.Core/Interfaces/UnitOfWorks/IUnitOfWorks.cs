using System.Threading.Tasks;
using Istip.DataAcquisition.Core.Interfaces.Repositories;

namespace Istip.DataAcquisition.Core.Interfaces.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        IExperimentRepository Experiments { get; }
        IFacilityRepository Facilities { get; }
        IOrganizationRepository Organization { get; }
        IWorkstationRepository Workstations { get; }
        Task CommitAsync();
        void Commit();
    }
}