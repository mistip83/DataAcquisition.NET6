using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.API.Filters;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkstationController : ControllerBase
    {
        private readonly IWorkstationService _workstationService;
        private readonly IMapper _mapper;

        public WorkstationController(IWorkstationService workstationService, IMapper mapper)
        {
            _workstationService = workstationService ?? throw new ArgumentNullException(nameof(workstationService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Returns Workstation Dto by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetWorkstationInfo(int id)
        {
            var workstation = await _workstationService.GetByIdAsync(id);
            return Ok(_mapper.Map<WorkstationDto>(workstation));
        }

        /// <summary>
        /// Returns Workstation List
        /// </summary>
        /// <returns></returns>
        [HttpGet("workstation-list")]
        public async Task<IActionResult> GetWorkstationList()
        {
            var workstationList = await _workstationService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<Workstation>, IEnumerable<WorkstationDto>>(workstationList));
        }

        /// <summary>
        /// Returns Workstation with devices and experiments
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}/devices-experiments")]
        public async Task<IActionResult> GetWorkstationWithDevicesAndExperiments(int id)
        {
            var workstationList = await _workstationService.GetWorkstationWithDevicesAndExperimentsAsync(id);
            return Ok(_mapper.Map<WorkstationWithDevicesAndExps>(workstationList));
        }

        /// <summary>
        /// Edits Workstation properties
        /// </summary>
        /// <param name="workstationDto"></param>
        /// <returns></returns>
        [ValidationFilter]
        [HttpPut("edit-workstation")]
        public IActionResult EditWorkstation(WorkstationDto workstationDto)
        {
            _workstationService.Update(_mapper.Map<Workstation>(workstationDto));
            return NoContent();
        }

        /// <summary>
        /// Add new workstation
        /// </summary>
        /// <param name="workstationDto"></param>
        /// <returns></returns>
        [ValidationFilter]
        [HttpPost("add-workstation")]
        public async Task<IActionResult> AddWorkstation(WorkstationDto workstationDto)
        {
            var newWorkstation = await _workstationService.AddAsync(_mapper.Map<Workstation>(workstationDto));
            return Created(string.Empty, _mapper.Map<WorkstationDto>(newWorkstation));
        }

        /// <summary>
        /// Delete Workstation
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete-workstation/{id:int}")]
        public async Task<IActionResult> DeleteWorkstation(int id)
        {
            var workstation = await _workstationService.GetByIdAsync(id);
            _workstationService.Remove(workstation);

            return NoContent();
        }
    }
}
