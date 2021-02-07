using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetCompanyWithFacilitiesAsync(Guid id);
    }
}
