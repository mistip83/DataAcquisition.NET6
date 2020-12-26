using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Core.Models.License;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IOrganizationService : IService<Organization>
    {
        bool CheckLicense(LicenseInfo license);
    }
}
