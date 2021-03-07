using System;
using System.Threading.Tasks;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Repository.Repositories
{
    /// <summary>
    /// Encapsulate the logic required to access data sources
    /// </summary>
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private AppDbContext AppDbContext => Context;

        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Implementation detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Company> GetCompanyWithFacilitiesAsync(Guid id)
        {
            return await AppDbContext.Company.Include(x => x.Facilities)
                .SingleOrDefaultAsync(x => x.CompanyId == id);
        }
    }
}