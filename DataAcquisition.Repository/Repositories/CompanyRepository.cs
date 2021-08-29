﻿using System.Threading.Tasks;
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
        public async Task<Company> GetCompanyWithFacilitiesAsync()
        {
            return await AppDbContext.Company.Include(x => x.Facilities)
                .SingleOrDefaultAsync();
        }

        /// <summary>
        /// Implementation detail
        /// </summary>
        public async Task<Company> GetCompanyInfoAsync()
        {
            return await AppDbContext.Company.SingleOrDefaultAsync();
        }

        /// <summary>
        /// Implementation detail
        /// </summary>
        public async Task<Company> GetOrganizationLayoutAsync()
        {
            return await AppDbContext.Company
                .Include(x => x.Facilities)
                .ThenInclude(x=>x.WorkStations)
                .ThenInclude(x=>x.Experiments)
                .SingleOrDefaultAsync();
        }
    }
}