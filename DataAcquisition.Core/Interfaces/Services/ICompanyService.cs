using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Core.Models.License;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface ICompanyService : IService<Company>
    {
        bool CheckLicense(LicenseInfo license);
    }
}
