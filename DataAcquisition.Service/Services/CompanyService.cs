using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.Entities;

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

        /// <summary>
        /// Returns company entity
        /// </summary>
        /// <returns></returns>
        public async Task<Company> GetCompanyInfoAsync()
        {
            return await UnitOfWork.Company.GetCompanyInfoAsync();
        }
    }
}