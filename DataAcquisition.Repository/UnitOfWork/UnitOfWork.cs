using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Repository.Repositories;

namespace DataAcquisition.Repository.UnitOfWork
{
    /// <summary>
    /// Reach database to commit changes to db
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private UserRepository _userRepository;
        private CompanyRepository _companyRepository;
        private FacilityReposity _facilityRepository;
        private WorkstationRepository _workstationRepository;
        private ExperimentRepository _experimentRepository;

        public IUserRepository User => _userRepository ??= new UserRepository(_context);
        public ICompanyRepository Company => _companyRepository ??= new CompanyRepository(_context);
        public IFacilityRepository Facility => _facilityRepository ??= new FacilityReposity(_context); 
        public IWorkstationRepository Workstation => _workstationRepository ??= new WorkstationRepository(_context);
        public IExperimentRepository Experiment => _experimentRepository ??= new ExperimentRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        /// <summary>
        /// Save changes
        /// </summary>
        public void Commit()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Save changes async
        /// </summary>
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}