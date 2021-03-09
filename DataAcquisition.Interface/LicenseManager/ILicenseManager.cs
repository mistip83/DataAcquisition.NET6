using System.Threading.Tasks;

namespace DataAcquisition.Interface.LicenseManager
{
    public interface ILicenseManager
    {
        public bool IsLicenseValid();
    }
}