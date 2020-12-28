using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;

namespace DataAcquisition.Core.Interfaces.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        IExperimentRepository Experiments { get; }
        IFacilityRepository Facilities { get; }
        ICompanyRepository Organization { get; }
        IWorkstationRepository Workstations { get; }
        Task CommitAsync();
        void Commit();
    }
}