using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service
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
        public async Task<Company> GetCompanyWithFacilitiesAsync()
        {
            return await UnitOfWork.Company.GetCompanyWithFacilitiesAsync();
        }

        /// <summary>
        /// Returns company entity
        /// </summary>
        public async Task<Company> GetCompanyInfoAsync()
        {
            return await UnitOfWork.Company.GetCompanyInfoAsync();
        }

        /// <summary>
        /// Returns Company, Facilities, Workstations, Experiments
        /// </summary>
        public async Task<Company> GetOrganizationLayoutAsync()
        {
            return await UnitOfWork.Company.GetOrganizationLayoutAsync();
        }
    }
}