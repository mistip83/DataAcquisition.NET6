using Microsoft.AspNetCore.Mvc;
using DataAcquisition.Interface.LicenseManager;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly ILicenseManager _licenseManager;

        public LicenseController(ILicenseManager licenseManager)
        {
            _licenseManager = licenseManager;
        }

        [HttpGet]
        public IActionResult CheckLicense()
        {
            return Ok(_licenseManager.IsLicenseValid());
        }
    }
}
