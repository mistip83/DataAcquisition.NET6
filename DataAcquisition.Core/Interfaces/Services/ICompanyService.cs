using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<Company> GetCompanyInfo();
    }
}
