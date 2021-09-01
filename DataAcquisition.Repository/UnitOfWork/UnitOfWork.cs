using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Repository.Repositories;

namespace DataAcquisition.Repository.UnitOfWork
{
    /// <summary>
    /// Reach database to commit/apply/save changes to db
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private UserRepository _userRepository;
        private CompanyRepository _companyRepository;
        private FacilityReposity _facilityRepository;
        private WorkstationRepository _workstationRepository;
        private ExperimentRepository _experimentRepository;

        public IUserRepository Users => _userRepository ??= new UserRepository(_context);
        public ICompanyRepository Company => _companyRepository ??= new CompanyRepository(_context);
        public IFacilityRepository Facilities => _facilityRepository ??= new FacilityReposity(_context); 
        public IWorkstationRepository Workstations => _workstationRepository ??= new WorkstationRepository(_context);
        public IExperimentRepository Experiments => _experimentRepository ??= new ExperimentRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        /// <summary>
        /// Save changes sync
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