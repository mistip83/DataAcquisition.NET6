using System.Threading.Tasks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Service.DatabaseServices
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
        /// <returns></returns>
        public async Task<Company> GetCompanyWithFacilitiesAsync()
        {
            return await UnitOfWork.Company.GetCompanyWithFacilitiesAsync();
        }

        /// <summary>
        /// Returns company entity
        /// </summary>
        /// <returns></returns>
        public async Task<Company> GetCompanyInfoAsync()
        {
            return await UnitOfWork.Company.GetCompanyInfoAsync();
        }

        /// <summary>
        /// Returns Company, Facilities, Workstations, Experiments
        /// </summary>
        /// <returns></returns>
        public async Task<Company> GetOrganizationLayoutAsync()
        {
            return await UnitOfWork.Company.GetOrganizationLayoutAsync();
        }
    }
}