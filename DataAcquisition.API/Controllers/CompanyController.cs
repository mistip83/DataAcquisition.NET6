using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService ?? throw new ArgumentNullException(nameof(companyService));
        }

        /// <summary>
        /// Returns Company Name
        /// </summary>
        [HttpGet("company-info")]
        public async Task<ActionResult<Company>> GetCompanyInfo()
        {
            return await _companyService.GetCompanyInfoAsync();
            
        }

        /// <summary>
        /// Returns Company, Facilities, Workstations, Devices and Experiments
        /// </summary>
        [HttpGet("organization-layout")]
        public async Task<ActionResult<Company>> GetOrganizationLayout()
        {
            return await _companyService.GetOrganizationLayoutAsync();
        }
    }
}
