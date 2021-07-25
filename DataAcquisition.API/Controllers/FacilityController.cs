using System.Collections.Generic;
using DataAcquisition.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Model.DTOs;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public FacilityController(IFacilityService facilityService, ICompanyService companyService, IMapper mapper)
        {
            _facilityService = facilityService;
            _companyService = companyService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns Facility Dto by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetFacilityInfo(int id)
        {
            var facility = await _facilityService.GetByIdAsync(id);
            return Ok(_mapper.Map<FacilityDto>(facility));
        }

        /// <summary>
        /// Returns Facility List
        /// </summary>
        /// <returns></returns>
        [HttpGet("facility-list")]
        public async Task<IActionResult> GetFacilityList()
        {
            var facility = await _facilityService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<Facility>, IEnumerable<FacilityDto>>(facility));
        }

        /// <summary>
        /// Returns Facility with workstations
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}/workstations")]
        public async Task<IActionResult> GetFacilityWithWorkStations(int id)
        {
            var facilityWithWorkstations = await _facilityService.GetFacilityWithWorkStationsAsync(id);
            return Ok(_mapper.Map<FacilityWithWorkstationsDto>(facilityWithWorkstations));
        }

        /// <summary>
        /// Edits Facility Properties
        /// </summary>
        /// <param name="facilityDto"></param>
        /// <returns></returns>
        [HttpPut("edit-facility")]
        public async Task<IActionResult> EditFacility(FacilityDto facilityDto)
        {
            var facility = _mapper.Map<Facility>(facilityDto);
            var company = await _companyService.GetCompanyInfoAsync();
            facility.CompanyName = company.CompanyName;

            _facilityService.Update(facility);
            return NoContent();
        }
    }
}
