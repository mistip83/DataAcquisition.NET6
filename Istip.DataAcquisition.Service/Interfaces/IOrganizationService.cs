using Istip.DataAcquisition.Core.EntityModels;
using Istip.DataAcquisition.LicenseManager.Models;

namespace Istip.DataAcquisition.Service.Interfaces
{
    public interface IOrganizationService : IService<Organization>
    {
        bool CheckLicense(LicenseInfo license);
    }
}
