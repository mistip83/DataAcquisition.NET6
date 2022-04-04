using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories;

public interface ICompanyRepository
{
    Task<Company> GetCompanyInfoAsync();
    Task<Company> GetCompanyWithFacilitiesAsync();
    Task<Company> GetOrganizationLayoutAsync();
}