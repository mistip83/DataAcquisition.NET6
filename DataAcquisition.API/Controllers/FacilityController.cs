using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces;
using DataAcquisition.Core.Interfaces.Configuration;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.DTOs;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;
        private readonly IAppConfiguration _appConfiguration;
        private readonly IMapper _mapper;

        public FacilityController(IFacilityService facilityService, IAppConfiguration appConfiguration, IMapper mapper)
        {
            _facilityService = facilityService ?? throw new ArgumentNullException(nameof(facilityService));
            _appConfiguration = appConfiguration ?? throw new ArgumentNullException(nameof(appConfiguration));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Returns Facility Dto by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetFacilityInfo(int id)
        {
            var facility = await _facilityService.GetByIdAsync(id);
            return Ok(_mapper.Map<FacilityDto>(facility));
        }

        /// <summary>
        /// Returns Facility List
        /// </summary>
        [HttpGet("facility-list")]
        public async Task<IActionResult> GetFacilityList()
        {
            var facility = await _facilityService.GetFacilitiesWithWorkStationsAsync();
            return Ok(_mapper.Map<IEnumerable<Facility>, IEnumerable<FacilityDto>>(facility));
        }

        /// <summary>
        /// Returns Facility with workstations
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}/workstations")]
        public async Task<IActionResult> GetFacilityWithWorkStations(int id)
        {
            var facilityWithWorkstations = await _facilityService.GetFacilityWithWorkStationsAsync(id);
            return Ok(_mapper.Map<FacilityWithWorkstationsDto>(facilityWithWorkstations));
        }

        /// <summary>
        /// Add new facility
        /// </summary>
        /// <param name="facilityDto"></param>
        [ValidationFilter]
        [HttpPost("add-facility")]
        public async Task<IActionResult> AddFacility(FacilityDto facilityDto)
        {
            var newFacility = await _facilityService.AddAsync(_mapper.Map<Facility>(facilityDto));
            return CreatedAtAction(nameof(GetFacilityInfo), new { id = newFacility.FacilityId }, 
                _mapper.Map<FacilityDto>(newFacility));
        }

        /// <summary>
        /// Edits Facility Properties
        /// </summary>
        /// <param name="facilityDto"></param>
        [ValidationFilter]
        [HttpPut("edit-facility")]
        public IActionResult EditFacility(FacilityDto facilityDto)
        {
            var facility = _mapper.Map<Facility>(facilityDto);
            facility.CompanyName = _appConfiguration.GetCompanyName();

            _facilityService.Update(facility);
            return NoContent();
        }
    }
}
