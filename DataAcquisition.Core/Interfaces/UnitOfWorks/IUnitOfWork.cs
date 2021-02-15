using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;

namespace DataAcquisition.Core.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICompanyRepository Company { get; }
        IFacilityRepository Facilities { get; }
        IWorkstationRepository Workstations { get; }
        Task CommitAsync();
        void Commit();
    }
}