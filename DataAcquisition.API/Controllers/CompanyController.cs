using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;
using System.Collections.Generic;
using System.Linq;

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
        [HttpGet]
        public async Task<IActionResult> GetOrganizationLayout()
        {
            var organizationLayout = await _companyService.GetOrganizationLayoutAsync();
            return Ok(organizationLayout);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = ""
                })
                .ToArray();
        }
    }
}
