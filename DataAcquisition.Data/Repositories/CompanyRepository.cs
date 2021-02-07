using System;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using System.Threading.Tasks;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private AppDbContext AppDbContext => Context as AppDbContext;

        public CompanyRepository(DbContext context) : base(context)
        {
        }

        public async Task<Company> GetCompanyWithFacilitiesByOrganizationIdAsync(Guid id)
        {
            return await AppDbContext.Companies.Include(x => x.Facilities)
                .SingleOrDefaultAsync(x => x.CompanyId == id);
        }
    }
}