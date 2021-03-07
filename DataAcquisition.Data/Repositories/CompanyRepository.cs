using System;
using System.Threading.Tasks;
using DataAcquisition.Data.DataAccess;
using DataAcquisition.Interface.Models.Entities;
using DataAcquisition.Interface.Repositories;
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