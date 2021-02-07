using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;

namespace DataAcquisition.Core.Interfaces.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        ICompanyRepository Companies { get; }
        IFacilityRepository Facilities { get; }
        IWorkstationRepository Workstations { get; }
        Task CommitAsync();
        void Commit();
    }
}