using System.Threading.Tasks;
using DataAcquisition.Interface.Repositories;

namespace DataAcquisition.Interface.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        ICompanyRepository Company { get; }
        IFacilityRepository Facilities { get; }
        IWorkstationRepository Workstations { get; }
        IExperimentRepository Experiments { get; }
        Task CommitAsync();
        void Commit();
    }
}