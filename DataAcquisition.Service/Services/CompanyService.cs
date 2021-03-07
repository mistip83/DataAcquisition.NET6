﻿using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.Interfaces.UnitOfWorks;
using DataAcquisition.Interface.Models.Entities;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;

namespace DataAcquisition.Service.Services
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class CompanyService : Service<Company>, ICompanyService
    {
        public CompanyService(IUnitOfWork unitOfWork, IRepository<Company> repository) : base(unitOfWork, repository)
        {
        }

        /// <summary>
        /// Returns company entity with its facilities
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Company> GetCompanyWithFacilitiesAsync(Guid id)
        {
            return await UnitOfWork.Company.GetCompanyWithFacilitiesAsync(id);
        }
    }
}