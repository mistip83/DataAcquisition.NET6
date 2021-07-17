using DataAcquisition.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using System;
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
        private readonly IMapper _mapper;

        public FacilityController(IFacilityService facilityService, IMapper mapper)
        {
            _facilityService = facilityService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns Facility Dto by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetFacilityInfo(Guid id)
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
            return Ok(_mapper.Map<FacilityDto>(facility));
        }

        /// <summary>
        /// Edits Facility Properties
        /// </summary>
        /// <param name="facilityDto"></param>
        /// <returns></returns>
        [HttpPut("edit-facility")]
        public IActionResult EditFacility(FacilityDto facilityDto)
        {
            _facilityService.Update(_mapper.Map<Facility>(facilityDto));
            return NoContent();
        }
    }
}
