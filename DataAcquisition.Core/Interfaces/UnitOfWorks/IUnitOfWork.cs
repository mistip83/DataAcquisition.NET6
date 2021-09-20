using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;

namespace DataAcquisition.Core.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        ICompanyRepository Company { get; }
        IFacilityRepository Facility { get; }
        IWorkstationRepository Workstation { get; }
        IExperimentRepository Experiment { get; }
        Task CommitAsync();
        void Commit();
    }
}