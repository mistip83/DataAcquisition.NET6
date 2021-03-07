using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.Models.Entities;

namespace DataAcquisition.Interface.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetCompanyWithFacilitiesAsync(Guid id);
    }
}
