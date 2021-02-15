using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using System.Threading.Tasks;
using DataAcquisition.Data.DataAccess;
using DataAcquisition.Data.Repositories;

namespace DataAcquisition.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private CompanyRepository _companyRepository;
        private FacilityReposity _facilityRepository;
        private WorkstationRepository _workstationRepository;

        public ICompanyRepository Company => _companyRepository ??= new CompanyRepository(_context);

        public IFacilityRepository Facilities => _facilityRepository ??= new FacilityReposity(_context);

        public IWorkstationRepository Workstations => _workstationRepository ??= new WorkstationRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}