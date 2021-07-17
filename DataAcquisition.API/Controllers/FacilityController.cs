using DataAcquisition.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Returns Facility Name by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetFacilityInfo(Guid id)
        {
            var facility = await _facilityService.GetFacilityInfoAsync(id);
            return Ok(_mapper.Map<FacilityDto>(facility));
        }

        /// <summary>
        /// Returns Facility List
        /// </summary>
        /// <returns></returns>
        [HttpGet("facility-list")]
        public async Task<IActionResult> GetFacilityList()
        {
            var facility = await _facilityService.GetFacilityList();
            return Ok(_mapper.Map<FacilityDto>(facility));
        }

        /// <summary>
        /// Edits Facility Properties
        /// </summary>
        /// <param name="facility"></param>
        /// <returns></returns>
        [HttpPut("edit-facility")]
        public IActionResult EditFacility(FacilityDto facility)
        {
            var updatedFacility = _facilityService.EditFacility(_mapper.Map<Facility>(facility));
            return Ok(_mapper.Map<FacilityDto>(updatedFacility));
        }
    }
}
