using System;
using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetCompanyInfoAsync();
        Task<Company> GetCompanyWithFacilitiesAsync(Guid id);
        Task<Company> GetOrganizationLayoutAsync();
    }
}
