using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _mapper = mapper;
            _companyService = companyService;
        }

        /// <summary>
        /// Returns Company Name
        /// </summary>
        /// <returns></returns>
        [HttpGet("company-info")]
        public async Task<IActionResult> GetCompanyInfo()
        {
            var company = await _companyService.GetCompanyInfoAsync();
            return Ok(_mapper.Map<CompanyDto>(company));
        }

        /// <summary>
        /// Returns Company, Facilities, Workstations, Experiments
        /// </summary>
        /// <returns></returns>
        [HttpGet("organization-layout")]
        public async Task<IActionResult> GetOrganizationLayout()
        {
            var organizationLayout = await _companyService.GetOrganizationLayoutAsync();
            return Ok(_mapper.Map<OrganizationDto>(organizationLayout));
        }
    }
}
