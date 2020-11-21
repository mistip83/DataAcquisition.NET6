using Istip.DataAcquisition.Core.Models.Entities;
using Istip.DataAcquisition.Core.Models.License;

namespace Istip.DataAcquisition.Core.Interfaces.Services
{
    public interface IOrganizationService : IService<Organization>
    {
        bool CheckLicense(LicenseInfo license);
    }
}
