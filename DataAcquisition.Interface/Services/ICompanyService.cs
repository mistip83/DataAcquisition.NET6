using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface ICompanyService
    {
        /// <summary>
        /// Returns company entity with its facilities
        /// </summary>
        Task<Company> GetCompanyWithFacilitiesAsync();

        /// <summary>
        /// Returns company entity
        /// </summary>
        Task<Company> GetCompanyInfoAsync();

        /// <summary>
        /// Returns Company, Facilities, Workstations, Experiments
        /// </summary>
        Task<Company> GetOrganizationLayoutAsync();
    }
}
