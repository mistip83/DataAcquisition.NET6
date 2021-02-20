using System;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using System.Threading.Tasks;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.Repositories
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