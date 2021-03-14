using System;
using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Repositories
{
    //Doesn't use IRepository<Company>, we don't want to make changes on the company
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetCompanyInfoAsync();
        Task<Company> GetCompanyWithFacilitiesAsync(Guid id);
    }
}
