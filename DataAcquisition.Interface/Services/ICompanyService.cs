using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface ICompanyService
    {
        /// <summary>
        /// Returns company entity with its facilities
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Company> GetCompanyWithFacilitiesAsync();

        /// <summary>
        /// Returns company entity
        /// </summary>
        /// <returns></returns>
        Task<Company> GetCompanyInfoAsync();

        /// <summary>
        /// Returns Company, Facilities, Workstations, Experiments
        /// </summary>
        /// <returns></returns>
        Task<Company> GetOrganizationLayoutAsync();
    }
}
